This is the translated version of PoeTradeSearch created by phiDelPark

Original Source:
https://github.com/phiDelPark/PoeTradeSearch

Usage: Ctrl+C on an item to price check

Additional shortcuts are located in the config file

Uses the official path of exile website to fetch item prices instead of poe.trade.

Can price check almost anything, including rare items, if you do happen to find an item that you are not able to price check, please submit an issue.

Has a dangerous mod checker for maps which can be set in the config file
Example: https://i.gyazo.com/b9fe5b00eb17c75a4eff10efb1cd9142.png

need atleast .net 4.6 framework for program to work

https://dotnet.microsoft.com/download/dotnet-framework

Config.txt
```
{
	"options":{
			"league":"Metamorph",           //League name ["Metamorph", "Hardcore Metamorph", "Standard", "Hardcore"]
			"server":"en",        
			"server_timeout":5,             //Server connection wait time (seconds) If the Internet is slow, raise it further to prevent timeout
			"server_redirect":false,        //Used when you cannot access the server
			"search_by_type":false,         //Search by type, not by item name. (Magic and rare equipment only)
			"search_before_day":0,          //[0, 1, 3, 7, 14] - 0 for any
			"search_price_min":0,           //Minimum price value (Unit is in chaos orbs)
			"search_price_count":20,        //Number of results to show when searching, max is 80
			"min_value_percent":80,         //Sets minimum value for the mod to a percentage of the original value
			"max_value_percent":130,        //Sets maximum value for the mod to a percentage of the original value
			"unique_min_value_percent":80,  //Sets minimum value for the mod of a unique item to a percentage of the original value
			"unique_max_value_percent":130, //Sets maximum value for the mod of a unique item to a percentage of the original value
			"set_max_value":false,          //Sets whether to input the max value [true, false]
			"auto_check_unique":true,       //If true, sets all mods of a unique item to the checked state 
			"auto_select_pseudo":true,      //If true, sets the mod type to pseudo
			"auto_select_corrupt":"no",     //If an item is corrupted, sets it to the value you have set ["yes", "no"]
			"ctrl_wheel":true,              //Enables ctrl_wheel for scrolling through stash tabs [true, false]
			"check_updates":true,           //Checks for update [true, false]
			"data_version":"3.9.2"
		},
	"shortcuts":[
			{"keycode":116,"value":"{Enter}/hideout{Enter}","Detail":"은신처 이동 (F5)"},
			{"keycode":115,"value":"{Enter}/exit{Enter}","Detail":"나가기 (F4)"},
			{"keycode":113,"value":"{Enter}/oos{Enter}","Detail":"남은 몬스터 수 (F2)"},
			{"keycode":118,"value":"Syndicate_0.jpg","position":"0x0","Detail":"이미지 출력, 단, .jpg만 가능 (F9)"},
			{"keycode":119,"value":"Temple_0.png","position":"0x0","Detail":"이미지 출력, 단, .jpg만 가능 (F10)"},
			{"keycode":122,"value":"{Pause}","Detail":"일시 중지 (F11)"},
			{"keycode":27,"value":"{Close}","Detail":"창 닫기 (ESC)"},
			{"keycode":78,"ctrl":true,"value":"{Link}https://poe.ninja/{Link}","Detail":"닌자 열기 (Ctrl+N)"},
			{"keycode":72,"ctrl":true,"value":"{Wiki}","Detail":"위키 열기 (Ctrl+H)"},
			{"keycode":0,"ctrl":true,"value":"{Run}","Detail":"작동키 (Ctrl+C) 변경은 프로젝트 홈 위키 참고"}
		],
	"checked":[ // Auto selects mods
			{"id":"Jewels/Amulets/Rings/Belts/Quivers/Armours/","text":"#% to Fire Resistance", "mod_type":"pseudo/explicit/implicit/crafted"}, 
			{"id":"Jewels/Amulets/Rings/Belts/Quivers/Armours/","text":"#% to Lightning Resistance", "mod_type":"pseudo/explicit/"},
			{"id":"Belts/","text":"# to Strength", "mod_type":"all"},
		], 
	"dangerous_mods":[ // Highlights dangerous map mods set
			{"id":"Maps/","text":"Monsters reflect #% of Elemental Damage"},
			{"id":"Maps/","text":"Monsters reflect #% of Physical Damage"},
		]
}```
