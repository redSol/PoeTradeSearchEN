﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows;

namespace PoeTradeSearch
{
    public partial class MainWindow : Window
    {
        private bool CheckUpdates()
        {
            bool isUpdates = false;

            // 마우스 훜시 프로그램에 딜레이가 생겨 쓰레드 처리
            try
            {
                Thread thread = new Thread(() =>
                {
                    string u = "https://raw.githubusercontent.com/redSol/PoeTradeSearchEN/master/VERSION";
                    string version = SendHTTP(null, u, 3);
                    if ((version ?? "") != "")
                    {
                        Version version1 = new Version(GetFileVersion());
                        isUpdates = version1.CompareTo(new Version(version)) < 0;
                    }
                });
                thread.Start();
                thread.Join();
            } catch (ArgumentException)
            {

            }
            return isUpdates;
        }

        private bool FilterDataUpdates(string path)
        {
            bool success = false;

            // 마우스 훜시 프로그램에 딜레이가 생겨 쓰레드 처리
            Thread thread = new Thread(() =>
            {
                string u = "https://pathofexile.com/api/trade/data/stats";
                string sResult = SendHTTP(null, u, 5);
                if ((sResult ?? "") != "")
                {
                    FilterData rootClass = Json.Deserialize<FilterData>(sResult);

                    for (int i = 0; i < rootClass.Result.Length; i++)
                    {
                        if (
                            rootClass.Result[i].Entries.Length > 0
                            && Restr.lFilterTypeName.ContainsKey(rootClass.Result[i].Entries[0].Type)
                        )
                        {
                            rootClass.Result[i].Label = Restr.lFilterTypeName[rootClass.Result[i].Entries[0].Type];
                        }
                    }

                    foreach (KeyValuePair<string, byte> itm in Restr.lParticular)
                    {
                        for (int i = 0; i < rootClass.Result.Length; i++)
                        {
                            
                            int index = Array.FindIndex(rootClass.Result[i].Entries, x => x.ID.Substring(x.ID.IndexOf(".") + 1) == itm.Key);
                            if (index > -1 && rootClass.Result[i].Entries[index].Text.IndexOf("(" + Restr.Local + ")") > 0)
                            {
                                rootClass.Result[i].Entries[index].Text = rootClass.Result[i].Entries[index].Text.Replace(" (" + Restr.Local + ")", "");
                                rootClass.Result[i].Entries[index].Part = itm.Value == 1 ? "Weapons" : "Armours";
                            }
                        }
                    }

                    foreach (KeyValuePair<string, bool> itm in Restr.lDisable)
                    {
                        for (int i = 0; i < rootClass.Result.Length; i++)
                        {
                            int index = Array.FindIndex(rootClass.Result[i].Entries, x => x.ID.Substring(x.ID.IndexOf(".") + 1) == itm.Key);
                            if (index > -1)
                            {
                                rootClass.Result[i].Entries[index].Text = "__DISABLE__";
                                rootClass.Result[i].Entries[index].Part = "Disable";
                            }
                        }
                    }

                    using (StreamWriter writer = new StreamWriter(path + "Filters.txt", false, Encoding.UTF8))
                    {
                        writer.Write(Json.Serialize<FilterData>(rootClass));
                    }

                    success = true;
                }
            });

            thread.Start();
            thread.Join();

            return success;
        }

        // 데이터 CSV 파일은 POE 클라이언트를 VisualGGPK.exe (libggpk) 를 통해 추출할 수 있다.
        private bool BaseDataUpdates(string path)
        {
            bool success = false;
            if (File.Exists(path + "csv/BaseItemTypes.csv") && File.Exists(path + "csv/Words.csv"))
            {
                try
                {
                    List<string[]> oCsvEnList = new List<string[]>();
                    List<string[]> oCsvKoList = new List<string[]>();

                    using (StreamReader oStreamReader = new StreamReader(File.OpenRead(path + "csv/en/BaseItemTypes.csv")))
                    {
                        string sEnContents = oStreamReader.ReadToEnd();
                        string[] sEnLines = sEnContents.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                        foreach (string sLine in sEnLines)
                        {
                            //oCsvEnList.Add(sLine.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries));
                            oCsvEnList.Add(Regex.Split(sLine, ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)"));
                        }
                    }

                    using (StreamReader oStreamReader = new StreamReader(File.OpenRead(path + "csv/ko/BaseItemTypes.csv")))
                    {
                        string sKoContents = oStreamReader.ReadToEnd();
                        string[] sKoLines = sKoContents.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                        foreach (string sLine in sKoLines)
                        {
                            //oCsvKoList.Add(sLine.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries));
                            oCsvKoList.Add(Regex.Split(sLine, ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)"));
                        }
                    }

                    List<BaseResultData> datas = new List<BaseResultData>();

                    for (int i = 1; i < oCsvEnList.Count; i++)
                    {
                        if (
                            oCsvEnList[i][6] == "Metadata/Items/Currency/AbstractMicrotransaction"
                            || oCsvEnList[i][6] == "Metadata/Items/HideoutDoodads/AbstractHideoutDoodad"
                        )
                            continue;

                        BaseResultData baseResultData = new BaseResultData();
                        baseResultData.ID = oCsvEnList[i][1].Replace("Metadata/Items/", "");
                        baseResultData.InheritsFrom = oCsvEnList[i][6].Replace("Metadata/Items/", "");
                        baseResultData.NameEn = oCsvEnList[i][5];
                        baseResultData.NameEn = oCsvKoList[i][5];
                        baseResultData.Detail = "";

                        if (datas.Find(x => x.NameEn == baseResultData.NameEn) == null)
                            datas.Add(baseResultData);
                    }

                    BaseData rootClass = Json.Deserialize<BaseData>("{\"result\":[{\"data\":[]}]}");
                    rootClass.Result[0].Data = datas.ToArray();

                    using (StreamWriter writer = new StreamWriter(path + "Bases.txt", false, Encoding.UTF8))
                    {
                        writer.Write(Json.Serialize<BaseData>(rootClass));
                    }

                    //-----------------------------

                    oCsvEnList = new List<string[]>();
                    oCsvKoList = new List<string[]>();

                    using (StreamReader oStreamReader = new StreamReader(File.OpenRead(path + "csv/en/Words.csv")))
                    {
                        string sEnContents = oStreamReader.ReadToEnd();
                        string[] sEnLines = sEnContents.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                        foreach (string sLine in sEnLines)
                        {
                            oCsvEnList.Add(Regex.Split(sLine, ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)"));
                        }
                    }

                    using (StreamReader oStreamReader = new StreamReader(File.OpenRead(path + "csv/ko/Words.csv")))
                    {
                        string sKoContents = oStreamReader.ReadToEnd();
                        string[] sKoLines = sKoContents.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                        foreach (string sLine in sKoLines)
                        {
                            oCsvKoList.Add(Regex.Split(sLine, ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)"));
                        }
                    }

                    List<WordeResultData> wdatas = new List<WordeResultData>();

                    for (int i = 1; i < oCsvEnList.Count; i++)
                    {
                        WordeResultData wordeResultData = new WordeResultData();
                        wordeResultData.Key = oCsvEnList[i][1];
                        wordeResultData.NameEn = oCsvEnList[i][6];
                        wordeResultData.NameEn = oCsvKoList[i][6];
                        wdatas.Add(wordeResultData);
                    }

                    WordData wordClass = Json.Deserialize<WordData>("{\"result\":[{\"data\":[]}]}");
                    wordClass.Result[0].Data = wdatas.ToArray();

                    using (StreamWriter writer = new StreamWriter(path + "Words.txt", false, Encoding.UTF8))
                    {
                        writer.Write(Json.Serialize<WordData>(wordClass));
                    }

                    //-----------------------------

                    oCsvEnList = new List<string[]>();
                    oCsvKoList = new List<string[]>();

                    using (StreamReader oStreamReader = new StreamReader(File.OpenRead(path + "csv/en/Prophecies.csv")))
                    {
                        string sEnContents = oStreamReader.ReadToEnd();
                        string[] sEnLines = sEnContents.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                        foreach (string sLine in sEnLines)
                        {
                            oCsvEnList.Add(Regex.Split(sLine, ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)"));
                        }
                    }

                    using (StreamReader oStreamReader = new StreamReader(File.OpenRead(path + "csv/ko/Prophecies.csv")))
                    {
                        string sKoContents = oStreamReader.ReadToEnd();
                        string[] sKoLines = sKoContents.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                        foreach (string sLine in sKoLines)
                        {
                            oCsvKoList.Add(Regex.Split(sLine, ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)"));
                        }
                    }

                    datas = new List<BaseResultData>();

                    for (int i = 1; i < oCsvEnList.Count; i++)
                    {
                        BaseResultData baseResultData = new BaseResultData();
                        baseResultData.ID = "Prophecies/" + oCsvEnList[i][1];
                        baseResultData.InheritsFrom = "Prophecies/Prophecy";
                        baseResultData.NameEn = oCsvEnList[i][4];
                        baseResultData.NameEn = oCsvKoList[i][4];
                        baseResultData.Detail = "";

                        datas.Add(baseResultData);
                    }

                    rootClass = Json.Deserialize<BaseData>("{\"result\":[{\"data\":[]}]}");
                    rootClass.Result[0].Data = datas.ToArray();

                    using (StreamWriter writer = new StreamWriter(path + "Prophecies.txt", false, Encoding.UTF8))
                    {
                        writer.Write(Json.Serialize<BaseData>(rootClass));
                    }

                    //-----------------------------

                    oCsvEnList = new List<string[]>();
                    oCsvKoList = new List<string[]>();

                    using (StreamReader oStreamReader = new StreamReader(File.OpenRead(path + "csv/en/MonsterVarieties.csv")))
                    {
                        string sEnContents = oStreamReader.ReadToEnd();
                        string[] sEnLines = sEnContents.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                        foreach (string sLine in sEnLines)
                        {
                            oCsvEnList.Add(Regex.Split(sLine, ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)"));
                        }
                    }

                    using (StreamReader oStreamReader = new StreamReader(File.OpenRead(path + "csv/ko/MonsterVarieties.csv")))
                    {
                        string sKoContents = oStreamReader.ReadToEnd();
                        string[] sKoLines = sKoContents.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                        foreach (string sLine in sKoLines)
                        {
                            oCsvKoList.Add(Regex.Split(sLine, ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)"));
                        }
                    }

                    datas = new List<BaseResultData>();

                    for (int i = 1; i < oCsvEnList.Count; i++)
                    {
                        BaseResultData baseResultData = new BaseResultData();
                        baseResultData.ID = oCsvEnList[i][1].Replace("Metadata/Monsters/", "");
                        baseResultData.InheritsFrom = oCsvEnList[i][11].Replace("Metadata/Monsters/", "");
                        baseResultData.NameEn = oCsvEnList[i][35];
                        baseResultData.NameEn = oCsvKoList[i][35];
                        baseResultData.Detail = "";

                        if (datas.Find(x => x.NameEn == baseResultData.NameEn) == null)
                            datas.Add(baseResultData);
                    }

                    rootClass = Json.Deserialize<BaseData>("{\"result\":[{\"data\":[]}]}");
                    rootClass.Result[0].Data = datas.ToArray();

                    using (StreamWriter writer = new StreamWriter(path + "Monsters.txt", false, Encoding.UTF8))
                    {
                        writer.Write(Json.Serialize<BaseData>(rootClass));
                    }

                    success = true;
                }
                catch { }
            }

            return success;
        }
    }
}
