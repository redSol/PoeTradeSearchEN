This is the translated version of PoeTradeSearch created by phiDelPark

Original Source:
https://github.com/phiDelPark/PoeTradeSearch

Usage: Ctrl+C on an item to price check

Additional shortcuts are located in the config file

Features:
- Fetches prices from official pathofexile website
- Has an advanced item search, can edit min and max values
- Has a currency exchange search
- Has a dangerous map mod checker, will highlight mods in red if the mod is set in the config file
 -> Example: https://i.gyazo.com/b9fe5b00eb17c75a4eff10efb1cd9142.png
- Has hotkeys for quality of life uses, such as ctrl + scroll wheel for stash tabs, /hideout, /oos, /kick charactername, a fast invite macro, and more which are customizable
- Has a poeprices.info tab for rare items
- Can show price results in the UI instead of opening browser, but also has the ability to open the item you are searching in browser

And more


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
			"data_version":"3.9.2",
			"always_on_top": true  		//If you want the UI to always stay on top no matter what process has focus [true, false]
		},
	"shortcuts": [
		    {
		      "keycode": 117,
		      "value": "{invite}",
		      "position": null,
		      "ctrl": false
		    },
		    {
		      "keycode": 116,
		      "value": "{Enter}/hideout{Enter}",
		      "position": null,
		      "ctrl": false
		    },
		    {
		      "keycode": 115,
		      "value": "{Enter}/kick charactername{Enter}",
		      "position": null,
		      "ctrl": false
		    },
		    {
		      "keycode": 113,
		      "value": "{Enter}/oos{Enter}",
		      "position": null,
		      "ctrl": false
		    },
		    {
		      "keycode": 118,
		      "value": "Syndicate_0.jpg",
		      "position": "0x0",
		      "ctrl": false
		    },
		    {
		      "keycode": 119,
		      "value": "Temple_0.jpg",
		      "position": "0x0",
		      "ctrl": false
		    },
		    {
		      "keycode": 122,
		      "value": "{Pause}",
		      "position": null,
		      "ctrl": false
		    },
		    {
		      "keycode": 27,
		      "value": "{Close}",
		      "position": null,
		      "ctrl": false
		    },
		    {
		      "keycode": 78,
		      "value": "{Link}https://poe.ninja/{Link}",
		      "position": null,
		      "ctrl": true
		    },
		    {
		      "keycode": 72,
		      "value": "{Wiki}",
		      "position": null,
		      "ctrl": true
		    },
		    {
		      "keycode": 0,
		      "value": "{Run}",
		      "position": null,
		      "ctrl": true
		    }
		  ],
		  "checked": [
		    {
		      "id": "Jewels/Amulets/Rings/Belts/Quivers/Armours/",
		      "text": "#% to Fire Resistance",
		      "mod_type": "pseudo/explicit/implicit/crafted"
		    },
		    {
		      "id": "Jewels/Amulets/Rings/Belts/Quivers/Armours/",
		      "text": "#% to Lightning Resistance",
		      "mod_type": "pseudo/explicit/"
		    },
		    {
		      "id": "Belts/",
		      "text": "# to Strength",
		      "mod_type": "all"
		    }
		  ],
		  "dangerous_mods": [
		    {
		      "id": "Maps/",
		      "text": "Monsters reflect #% of Elemental Damage"
		    },
		    {
		      "id": "Maps/",
		      "text": "Monsters reflect #% of Physical Damage"
		    }
		  ]
}
```
