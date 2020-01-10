using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Threading;

namespace PoeTradeSearch
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<BaseResultData> mBaseDatas = null;
        private List<WordeResultData> mWordDatas = null;
        private List<BaseResultData> mProphecyDatas = null;
        private List<BaseResultData> mMonsterDatas = null;
        
        private ConfigData mConfigData;
        private FilterData mFilterData;

        private ItemBaseName mItemBaseName;

        private System.Windows.Forms.NotifyIcon TrayIcon;

        private bool mTerminate = false;
        private bool mDisableClip = false;
        private bool mAdministrator = false;
        private bool mCreateDatabase = false;

        private static bool mIsHotKey = false;
        public static bool mIsPause = false;

        public static DateTime MouseHookCallbackTime;    

        public MainWindow()
        {
            InitializeComponent();

            Uri uri = new Uri("pack://application:,,,/PoeTradeSearch;component/Icon1.ico");
            using (Stream iconStream = Application.GetResourceStream(uri).Stream)
            {
                TrayIcon = new System.Windows.Forms.NotifyIcon
                {
                    Icon = new Icon(iconStream),
                    Visible = true
                };

                TrayIcon.MouseClick += (sender, args) =>
                {
                    switch (args.Button)
                    {
                        case System.Windows.Forms.MouseButtons.Left:
                            break;

                        case System.Windows.Forms.MouseButtons.Right:
                            if (
                                MessageBox.Show(
                                    "Do you want to close the program?", "POE Trade Search",
                                    MessageBoxButton.YesNo, MessageBoxImage.Question
                                ) == MessageBoxResult.Yes
                            )
                            {
                                //Application.Current.Shutdown();
                                mTerminate = true;
                                Close();
                            }
                            break;
                    }
                };
            }

            mAdministrator = IsAdministrator();

            string[] clArgs = Environment.GetCommandLineArgs();

            if (clArgs.Length > 1)
            {
                mCreateDatabase = clArgs[1].ToLower() == "-createdatabase";
            }
        }

        private static IntPtr mMainHwnd;
        private static int closeKeyCode = 0;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (!Setting())
            {
                Application.Current.Shutdown();
                return;
            }

            Restr.ServerType = Restr.ServerType == "" ? mConfigData.Options.League : Restr.ServerType;
            Restr.ServerType = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Restr.ServerType.ToLower()).Replace(" ", "%20");
            Restr.ServerLang = (byte)(mConfigData.Options.Server == "en" ? 1 : 0);

            ComboBox[] cbs = { cbOrbs, cbSplinters , cbCorrupt, cbPriceListCount, cbInfluence1, cbInfluence2 };
            foreach(ComboBox cb in cbs)
            {
                ControlTemplate ct = cb.Template;
                Popup popup = ct.FindName("PART_Popup", cb) as Popup;
                if (popup != null)
                    popup.Placement = PlacementMode.Top;
            }

            int cnt = 0;
            cbOrbs.Items.Add("Select the orbs you want to exchange");
            cbSplinters.Items.Add("Select the fossils, splinters you want");
            foreach (KeyValuePair<string, string> item in Restr.lExchangeCurrency)
            {
                if (item.Key == "Blacksmith Whetstone")
                    break;

                if (cnt++ > 33)
                    cbSplinters.Items.Add(item.Key);
                else
                    cbOrbs.Items.Add(item.Key);
            }

            mMainHwnd = new WindowInteropHelper(this).Handle;

            if (mAdministrator)
            {
                foreach (var item in mConfigData.Shortcuts)
                {
                    if (item.Keycode > 0 && (item.Value ?? "") != "")
                    {
                        if (!mDisableClip && item.Value.ToLower() == "{run}")
                            mDisableClip = true;
                        else if (item.Value.ToLower() == "{close}")
                            closeKeyCode = item.Keycode;
                    }
                }
            }

            HwndSource source = HwndSource.FromHwnd(mMainHwnd);
            source.AddHook(new HwndSourceHook(WndProc));

            string tmp = "Program version " + GetFileVersion() + " 을(를) 시작합니다." + '\n' + '\n' +
                    "* Usage: In game press Ctrl + C on an in-game item." + '\n' + "* To close the program, right click on the tray icon." + '\n' + '\n' +
                    (mAdministrator ? "Additional shortcuts have been enabled" : "To use the additional shortcuts, the program must be ran as administrator") + "";

            if (mConfigData.Options.CheckUpdates && CheckUpdates())
            {
                MessageBoxResult result = MessageBox.Show(Application.Current.MainWindow,
                        tmp + '\n' + '\n' + "The latest version of this program has been found." + '\n' + "Would you like to get that verison now?",
                        "POE 거래소 검색", MessageBoxButton.YesNo, MessageBoxImage.Question
                    );

                if (result == MessageBoxResult.Yes)
                {
                    Process.Start("https://github.com/redSol/PoeTradeSearchEN/releases");
                    mTerminate = true;
                    Close();
                }
            }
            else
            {
                MessageBox.Show(Application.Current.MainWindow, tmp + '\n' + "Press the top of the program (?) for more information.", "POE Exchange Search - created by phiDelPark");
            }

            if (!mDisableClip)
            {
                IntPtr mNextClipBoardViewerHWnd = Native.SetClipboardViewer(new WindowInteropHelper(this).Handle);
            }

            if (mAdministrator)
            {
                //InstallRegisterHotKey();

                // 창 활성화 후킹 사용시 가끔 꼬여서 타이머로 교체 (타이머를 쓰면 다른 목적으로 사용도 가능하고...)
                //EventHook.EventAction += new EventHandler(WinEvent);
                //EventHook.Start();

                DispatcherTimer timer = new DispatcherTimer();
                timer.Interval = TimeSpan.FromMilliseconds(1000);
                timer.Tick += new EventHandler(Timer_Tick);
                timer.Start();

                if (mConfigData.Options.CtrlWheel)
                {
                    MouseHookCallbackTime = Convert.ToDateTime(DateTime.Now);
                    MouseHook.MouseAction += new EventHandler(MouseEvent);
                    MouseHook.Start();
                }
            }

            this.Title += " - " + Restr.ServerType;
            this.Visibility = Visibility.Hidden;
        }

        private void Window_Activated(object sender, EventArgs e)
        {

        }

        private void Window_Deactivated(object sender, EventArgs e)
        {
            WindowInteropHelper helper = new WindowInteropHelper(this);
            long ip = Native.SetWindowLong(
                helper.Handle,
                Native.GWL_EXSTYLE,
                Native.GetWindowLong(helper.Handle, Native.GWL_EXSTYLE) | Native.WS_EX_NOACTIVATE
            );
            btnClose.Background = btnSearch.Background;
            btnClose.Foreground = btnSearch.Foreground;
        }

        private void TbOpt0_0_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (!this.IsFocused)
            {
                WindowInteropHelper helper = new WindowInteropHelper(this);
                long ip = Native.SetWindowLong(
                    helper.Handle,
                    Native.GWL_EXSTYLE,
                    Native.GetWindowLong(helper.Handle, Native.GWL_EXSTYLE) & ~Native.WS_EX_NOACTIVATE
                );
                Native.SetForegroundWindow(helper.Handle);
                btnClose.Background = System.Windows.SystemColors.HighlightBrush;
                btnClose.Foreground = System.Windows.SystemColors.HighlightTextBrush;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string sEntity;
            string url = "";
            string[] exchange = null;

            if (bdExchange.Visibility == Visibility.Visible && (cbOrbs.SelectedIndex > 0 || cbSplinters.SelectedIndex > 0))
            {
                exchange = new string[2];
                exchange[0] = Restr.lExchangeCurrency[mItemBaseName.TypeEN];
                exchange[1] = Restr.lExchangeCurrency[(string)(cbOrbs.SelectedIndex > 0 ? cbOrbs.SelectedValue : cbSplinters.SelectedValue)];
                url = Restr.ExchangeApi[Restr.ServerLang] + Restr.ServerType + "/?redirect&source=";
                url += Uri.EscapeDataString("{\"exchange\":{\"status\":{\"option\":\"online\"},\"have\":[\"" + exchange[0] + "\"],\"want\":[\"" + exchange[1] + "\"]}}");
                Process.Start(url);
            }
            else
            {
                sEntity = CreateJson(GetItemOptions(), false);

                if (sEntity == null || sEntity == "")
                {
                    ForegroundMessage("Json 생성을 실패했습니다.", "에러", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                if (mConfigData.Options.ServerRedirect)
                {
                    url = Restr.TradeApi[Restr.ServerLang] + Restr.ServerType + "/?redirect&source=";
                    url += Uri.EscapeDataString(sEntity);
                    Process.Start(url);
                }
                else
                {
                    string sResult = null;

                    // 마우스 훜시 프로그램에 딜레이가 생겨 쓰레드 처리
                    Thread thread = new Thread(() =>
                    {
                        sResult = SendHTTP(sEntity, Restr.TradeApi[Restr.ServerLang] + Restr.ServerType, mConfigData.Options.ServerTimeout);
                        if ((sResult ?? "") != "")
                        {
                            try
                            {
                                ResultData resultData = Json.Deserialize<ResultData>(sResult);
                                url = Restr.TradeUrl[Restr.ServerLang] + Restr.ServerType + "/" + resultData.ID;
                                Process.Start(url);
                            }
                            catch { }
                        }
                    });

                    thread.Start();
                    thread.Join();

                    if ((sResult ?? "") == "")
                    {
                        ForegroundMessage(
                            "Server cannot be connected right now.",
                            "Search failed",
                            MessageBoxButton.OK, MessageBoxImage.Information
                        );
                        return;
                    }
                }
            }

            Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void cbAiiCheck_Checked(object sender, RoutedEventArgs e)
        {
            bool is_checked = e.RoutedEvent.Name == "Checked";

            for (int i = 0; i < 10; i++)
            {
                if (((CheckBox)this.FindName("tbOpt" + i + "_2")).IsEnabled == true)
                    ((CheckBox)this.FindName("tbOpt" + i + "_2")).IsChecked = is_checked;
            }
        }

        private void TbOpt0_3_Checked(object sender, RoutedEventArgs e)
        {
            string idx = (string)((CheckBox)sender).Tag;
            ((TextBox)this.FindName("tbOpt" + idx)).Tag = ((TextBox)this.FindName("tbOpt" + idx)).Text;
            ((TextBox)this.FindName("tbOpt" + idx)).Text = Restr.TotalResistance;
        }

        private void TbOpt0_3_Unchecked(object sender, RoutedEventArgs e)
        {
            string idx = (string)((CheckBox)sender).Tag;
            ((TextBox)this.FindName("tbOpt" + idx)).Text = (string)((TextBox)this.FindName("tbOpt" + idx)).Tag;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Restr.ServerLang = byte.Parse((string)((Button)sender).Tag);

            if (Restr.ServerLang == 0)
                cbName.Content = (Regex.Replace(mItemBaseName.NameKR, @"\([a-zA-Z\s']+\)$", "") + " " + Regex.Replace(mItemBaseName.TypeKR, @"\([a-zA-Z\s']+\)$", "")).Trim();
            else
                cbName.Content = (mItemBaseName.NameEN + " " + mItemBaseName.TypeEN).Trim();

            SetSearchButtonText();
        }

        private void CbOrbs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (((ComboBox)sender).Name == "cbOrbs")
            {
                cbSplinters.SelectionChanged -= CbOrbs_SelectionChanged;
                cbSplinters.SelectedIndex = 0;
                cbSplinters.SelectionChanged += CbOrbs_SelectionChanged;
                cbSplinters.FontWeight = FontWeights.Normal;
            }
            else
            {
                cbOrbs.SelectionChanged -= CbOrbs_SelectionChanged;
                cbOrbs.SelectedIndex = 0;
                cbOrbs.SelectionChanged += CbOrbs_SelectionChanged;
                cbOrbs.FontWeight = FontWeights.Normal;
            }

            ((ComboBox)sender).FontWeight = ((ComboBox)sender).SelectedIndex == 0 ? FontWeights.Normal : FontWeights.SemiBold;

            SetSearchButtonText();
            TkPrice_MouseLeftButtonDown(null, null);
        }

        private void TkPrice_Mouse_EnterOrLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            tkPriceInfo1.Foreground = tkPriceInfo2.Foreground = e.RoutedEvent.Name == "MouseEnter" ? System.Windows.SystemColors.HighlightBrush : System.Windows.SystemColors.WindowTextBrush;
            tkPriceCount1.Foreground = tkPriceCount2.Foreground = e.RoutedEvent.Name == "MouseEnter" ? System.Windows.SystemColors.HighlightBrush : System.Windows.SystemColors.WindowTextBrush;
        }

        private void TkPrice_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            string[] exchange = null;

            if (bdExchange.Visibility == Visibility.Visible && (cbOrbs.SelectedIndex > 0 || cbSplinters.SelectedIndex > 0))
            {
                exchange = new string[2];
                exchange[0] = Restr.lExchangeCurrency[mItemBaseName.TypeEN];
                exchange[1] = Restr.lExchangeCurrency[(string)(cbOrbs.SelectedIndex > 0 ? cbOrbs.SelectedValue : cbSplinters.SelectedValue)];
            }

            PriceUpdateThreadWorker(exchange != null ? null : GetItemOptions(), exchange);
        }

        private void tkPriceInfo_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
             tabControl1.SelectedIndex = tabControl1.SelectedIndex == 0 ? 1 : 0;
        }

        private void cbName_Checked(object sender, RoutedEventArgs e)
        {
            cbName.Foreground = cbName.IsChecked == true ? lbDPS.Foreground : tbHelpText.Foreground;
            tkPrice_ReSet(null, null);
        }

        private void tkPrice_ReSet(object sender, RoutedEventArgs e)
        {
            try
            {
                tkPriceInfo1.Foreground = tkPriceInfo2.Foreground = System.Windows.Media.Brushes.DeepPink;
                tkPriceCount1.Foreground = tkPriceCount2.Foreground = System.Windows.Media.Brushes.DeepPink;
            }
            catch (Exception)
            {
            }
        }

        private void tbOpt0_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                PriceUpdateThreadWorker(GetItemOptions(), null);
            }
            catch (Exception)
            {
            }
        }

        private void tabControl1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cbPriceListTotal.Visibility = tabControl1.SelectedIndex == 1 ? Visibility.Visible : Visibility.Hidden;
            tbHelpText.Text = tabControl1.SelectedIndex == 1 ? "Minimum value unit is Chaos Orb" : "Click on price to re-search";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            try
            {
                Process.Start(
                    "https://pathofexile.gamepedia.com/" +
                    ((string)cbRarity.SelectedValue == Restr.Unique && mItemBaseName.NameEN != ""
                    ? mItemBaseName.NameEN : mItemBaseName.TypeEN).Replace(' ', '_')
                );
            }
            catch (Exception)
            {
                ForegroundMessage("Failed to link to item's wiki.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }



        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Application.Current.MainWindow,
                "Version: " + GetFileVersion() + " (D." + mConfigData.Options.DataVersion + ")" + '\n' + '\n' +
                "English Version: https://github.com/redSol/PoeTradeSearchEN" + '\n' + '\n' +
                "Original project: https://github.com/phiDelPark/PoeTradeSearch" + '\n' + '\n' + '\n' +
                "Mod selection can be configured in the config file." + '\n' + '\n' +
                "Additional hotkeys such as ctrl + mousewheel can be activated by running the program as administrator." + '\n' +
                "Program settings can be set in the config file located in the _POE_Data folder.",
                "POE Trade Search"
                );

            Native.SetForegroundWindow(Native.FindWindow(Restr.PoeClass, Restr.PoeCaption));
        }

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (closeKeyCode > 0 && KeyInterop.VirtualKeyFromKey(e.Key) == closeKeyCode)
                Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = !mTerminate;

            Keyboard.ClearFocus();
            this.Visibility = Visibility.Hidden;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            if (mAdministrator && mConfigData != null)
            {
                if (mIsHotKey)
                    RemoveRegisterHotKey();

                if (mConfigData.Options.CtrlWheel)
                    MouseHook.Stop();
            }

            TrayIcon.Visible = false;
            TrayIcon.Dispose();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            try
            {
                string tab = "";
                string itemRarity = cbRarity.Text;
                string itemName = (mItemBaseName.NameEN != "" ? mItemBaseName.NameEN : mItemBaseName.TypeEN).Replace(" ", "-").Replace("'", "").ToLower();
                string itemBaseType = mItemBaseName.TypeEN.Replace(" ", "-").Replace("'", "").ToLower();
                string itemInherit = mItemBaseName.Inherits[0].ToLower();
                bool useBase = false, useName = false;
                Console.WriteLine("mItemBaseName.NameEN:" + mItemBaseName.NameEN);
                Console.WriteLine("mItemBaseName.TypeEN:" + mItemBaseName.TypeEN);
                Console.WriteLine("inherits: " + mItemBaseName.Inherits[0].ToLower());
                switch (itemInherit)
                {
                    case "currency":
                        {
                            if (itemName.Contains("oil"))
                                tab = "oils";
                            else if (itemName.Contains("fossil"))
                                tab = "fossils";
                            else if (itemName.Contains("essence"))
                                tab = "essences";
                            else
                                tab = "currency";
                            useBase = true;

                            break;
                        }
                    case "mapfragments":
                        {
                            if (itemName.Contains("scarab"))
                                tab = "scarabs";
                            else
                                tab = "fragments";
                            useBase = true;
                            break;
                        }
                    case "atlasupgrades":
                        {
                            tab = "watchstones";
                            useBase = true;
                            useName = true;
                            break;
                        }
                    case "legion":
                        {
                            tab = "incubators";
                            useBase = true;
                            break;
                        }
                    case "delve":
                        {
                            tab = "resonators";
                            useBase = true;
                            break;
                        }
                    case "divinationcards":
                        {
                            tab = "divinationcards";
                            useBase = true;
                            break;
                        }
                    case "prophecies":
                        {
                            tab = "prophecies";
                            useBase = true;
                            break;
                        }
                    case "gems":
                        {
                            tab = "skill-gems";
                            useBase = true;
                            break;
                        }
                    case "maps":
                        {
                            if (itemRarity == "Unique")
                            {
                                tab = "unique-maps/" + itemName + "-t" + tbLvMin.Text.Trim();
                            } else
                            {
                                tab = "maps/" + itemBaseType + "-t" + tbLvMin.Text.Trim() + "-metamorph";
                            }
                            break;
                        }
                    case "jewels":
                        {
                            tab = "unique-jewels";
                            useBase = true;
                            useName = true;
                            break;
                        }
                    case "flasks":
                        {
                            tab = "unique-flasks";
                            useName = true;
                            break;
                        }
                    case "weapons":
                        {
                            tab = "unique-weapons";
                            useBase = true;
                            useName = true;
                            break;
                        }
                    case "armours":
                        {
                            tab = "unique-armours";
                            useBase = true;
                            useName = true;
                            break;
                        }
                    case "amulets":
                    case "rings":
                    case "belts":
                        {
                            tab = "unique-accessories";
                            useBase = true;
                            useName = true;
                            break;
                        }
                }

                if (itemInherit != "maps" && itemInherit != "atlasupgrades")
                {
                    if (useName && useBase)
                        tab = tab + "/" + itemName + "-" + itemBaseType;

                    else if (useName && !useBase)
                        tab = tab + "/" + itemName;

                    else if (!useName && useBase)
                        tab = tab + "/" + itemBaseType;

                    if (itemInherit == "gems")
                    {
                        if (int.Parse(tbLvMin.Text) == 1)
                            tab = tab + "-1";
                        else if (int.Parse(tbLvMin.Text) == 2)
                            tab = tab + "-2";
                        else if (int.Parse(tbLvMin.Text) == 3)
                            tab = tab + "-3";
                        else if (int.Parse(tbLvMin.Text) == 4)
                            tab = tab + "-4";
                        else if (int.Parse(tbLvMin.Text) == 20)
                            tab = tab + "-20";
                        else if (int.Parse(tbLvMin.Text) == 21)
                            tab = tab + "-21";

                        if (int.Parse(tbQualityMin.Text) == 20)
                            tab = tab + "-20";
                        else if (int.Parse(tbQualityMin.Text) == 21)
                            tab = tab + "-23c";
                    }

                    if (itemName.Contains("a-master-seeks-help"))
                    {
                        tab = "prophecies?name=a master seeks help";
                    }
                }
                Process.Start(
                    ("https://poe.ninja/challenge/" + tab));
            }
            catch (Exception)
            {
                ForegroundMessage("Failed to link to item's poe.ninja page", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}