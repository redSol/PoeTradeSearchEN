using System.Collections.Generic;

namespace PoeTradeSearch
{
    internal static class Restr
    {
        internal static string PoeClass = "POEWindowClass";
        internal static string PoeCaption = "Path of Exile";

        internal static string[] TradeUrl = { "https://poe.game.daum.net/trade/search/", "https://www.pathofexile.com/trade/search/" };
        internal static string[] TradeApi = { "https://poe.game.daum.net/api/trade/search/", "https://www.pathofexile.com/api/trade/search/" };
        internal static string[] FetchApi = { "https://poe.game.daum.net/api/trade/fetch/", "https://www.pathofexile.com/api/trade/fetch/" };
        internal static string[] ExchangeApi = { "https://poe.game.daum.net/api/trade/exchange/", "https://www.pathofexile.com/api/trade/exchange/" };

        internal static byte ServerLang = 1;
        internal static string ServerType = "";

        internal const string All = "All";
        internal const string Max = "Max";

        internal const string Rarity = "Rarity";
        internal const string Unique = "Unique";
        internal const string Rare = "Rare";
        internal const string Magic = "Magic";
        internal const string Normal = "Normal";

        internal const string Prophecy = "Prophecy";
        internal const string Currency = "Currency";
        internal const string DivinationCard = "Divination Card";
        internal const string Gem = "Gem";

        internal const string Higher = "Superior";
        internal const string Shaped = "Shaped";

        internal const string Lv = "Level";
        internal const string ItemLv = "Item Level";
        internal const string CharmLv = "Talisman Tier"; // Talisman
        internal const string MaTier = "Map Tier"; // Map Tier
        internal const string Quality = "Quality";
        internal const string Socket = "Sockets";

        internal const string Corrupt = "Corrupted";
        internal const string Vaal = "Vaal";
        internal const string Unidentify = "Unidentified";
        internal const string Blight = "Blight";
        internal const string Blighted = "Blighted";
        internal static string Metamorph =  "Metamorph";

        internal const string Shaper = "Shaper Item";
        internal const string Elder = "Elder Item";
        internal const string Crusader = "Crusader Item";
        internal const string Redeemer = "Redeemer Item";
        internal const string Hunter = "Hunter Item";
        internal const string Warlord = "Warlord Item";

        internal const string Synthesis = "Synthesised Item";
        internal const string Synthesised = "Synthesised";
        internal const string Captured = "Captured";

        internal const string ChkProphecy = "Right-click to add this prophecy to your character";
        internal const string ChkMapFragment = "Can be used in a personal Map Device";
        internal const string ChkMetEntrails = "Combine this with four other different samples in Tane's Laboratory";        
        internal const string ChkFlask = "Charges on use";
        internal const string ChkBeast1 = "Genus";
        internal const string ChkBeast2 = "Group";

        internal const string SClickSplitItem = "Shift click to unstack";    

        internal const string Pseudo = "Pseudo";
        internal const string Explicit = "Explicit";
        internal const string Fractured = "Fractured";
        internal const string Crafted = "crafted";
        internal const string Implicit = "implicit";
        internal const string Enchant = "Enchant";
        internal const string Veiled = "Veiled";
        internal const string Monster = "Monster";
        internal const string Delve = "Delve";
        internal const string Local = "Local";

        internal const string PhysicalDamage = "Physical Damage";
        internal const string ElementalDamage = "Elemental Damage";
        internal const string ChaosDamage = "Chaos Damage";
        internal const string AttacksPerSecond = "Attacks per Second";
        internal const string AttackSpeedIncr = "#% increased Attack Speed";
        internal const string PhysicalDamageIncr = "#% increased Physical Damage";
        internal const string TotalResistance = "+#% total Elemental Resistance";

        internal const string FlatPhysicalDamage = "Adds # to # Physical Damage";
        internal const string FlatAccuracyRating = "# to Accuracy Rating";
        internal const string FlatColdDamage = "Adds # to # Cold Damage";
        internal const string FlatLightningDamage = "Adds # to # Lightning Damage";
        internal const string FlatFireDamage = "Adds # to # Fire Damage";
        internal const string FlatChaosDamage = "Adds # to # Chaos Damage";

        internal const string EnergyShield = "#% increased Energy Shield";
        internal const string EvasionRating = "#% increased Evasion Rating";
        internal const string ArmourRating = "#% increased Armour";

        internal const string FlatEnergyShield = "# to maximum Energy Shield";
        internal const string FlatEvasionRating = "# to Evasion Rating";
        internal const string FlatArmourRating = "# to Armour";

        internal const string ArmourEvasionRating = "#% increased Armour and Evasion";
        internal const string ArmourEnergyShield = "#% increased Armour and Energy Shield";
        internal const string EvasionEnergyShield = "#% increased Evasion and Energy Shield";
        internal const string ArmourEvasionEnergyShield = "#% increased Armour, Evasion and Energy Shield";

        internal static Dictionary<string, string> lFilterTypeName = new Dictionary<string, string>()
        {
            { "pseudo", Pseudo}, { "explicit", Explicit}, { "fractured", Fractured}, { "crafted", Crafted}, { "implicit", Implicit},
            { "enchant", Enchant}, { "veiled", Veiled}, { "monster", Monster}, { "delve", Delve}
        };

        internal static Dictionary<string, bool> lDefaultPosition = new Dictionary<string, bool>()
        {
            { "stat_3441651621", true}, { "stat_3853018505", true}, { "stat_969865219", true},  { "stat_4176970656", true},
            { "stat_3277537093", true}, { "stat_3691641145", true}, { "stat_3557561376", true}, { "stat_705686721", true},
            { "stat_2156764291", true}, { "stat_3743301799", true}, { "stat_1187803783", true}, { "stat_3612407781", true},
            { "stat_496011033", true},  { "stat_1625103793", true}, { "stat_308618188", true},  { "stat_2590715472", true},
            { "stat_1964333391", true}, { "stat_614758785", true},  { "stat_2440172920", true}, { "stat_321765853", true},
            { "stat_465051235", true},  { "stat_261654754", true},  { "stat_3522931817", true}, { "stat_1443108510", true}, { "stat_2477636501", true}
        };

        internal static Dictionary<string, bool> lDisable = new Dictionary<string, bool>()
        {
            { "stat_1001829678", true}, { "stat_1778298516", true}, { "stat_2881111359", true},  { "stat_561307714", true}, { "stat_57434274", true},  { "stat_3666934677", true}
        };

        internal static Dictionary<string, byte> lParticular = new Dictionary<string, byte>()
        {
            { "stat_210067635", 1}, { "stat_691932474", 1}, { "stat_3885634897", 1}, { "stat_2223678961", 1},
            { "stat_1940865751", 1}, { "stat_3336890334", 1}, { "stat_709508406", 1}, { "stat_1037193709", 1},
            { "stat_4052037485", 2}, { "stat_4015621042", 2}, { "stat_124859000", 2}, { "stat_53045048", 2}, 
            { "stat_1062208444", 2}, { "stat_3484657501", 2}, { "stat_3321629045", 2}, { "stat_1999113824", 2}, { "stat_2451402625", 2}, { "stat_3523867985", 2 }
        };
        
        internal static Dictionary<string, bool> lResistance = new Dictionary<string, bool>()
        {
            { "stat_4220027924", true }, { "stat_3372524247", true }, { "stat_1671376347", true }, { "stat_2923486259", true },
            { "stat_2915988346", true }, { "stat_4277795662", true }, { "stat_3441501978", true }
        };

        internal static Dictionary<string, string> lPseudo = new Dictionary<string, string>()
        {
            { "stat_4220027924", "pseudo_total_cold_resistance" }, { "stat_3372524247", "pseudo_total_fire_resistance" }, { "stat_1671376347", "pseudo_total_lightning_resistance" }, { "stat_2923486259", "pseudo_total_chaos_resistance" },
            { "stat_3299347043", "pseudo_total_life" }, { "stat_1050105434", "pseudo_total_mana" }, { "stat_3489782002", "pseudo_total_energy_shield" }, { "stat_2482852589", "pseudo_increased_energy_shield" },
            { "stat_4080418644", "pseudo_total_strength" }, { "stat_3261801346", "pseudo_total_dexterity" }, { "stat_328541901", "pseudo_total_intelligence" },
            { "stat_681332047", "pseudo_total_attack_speed" }, { "stat_2891184298", "pseudo_total_cast_speed" }, { "stat_2250533757", "pseudo_increased_movement_speed" },
            { "stat_587431675", "pseudo_global_critical_strike_chance" }, { "stat_3556824919", "pseudo_global_critical_strike_multiplier" }, { "stat_737908626", "pseudo_critical_strike_chance_for_spells" },
            { "stat_1509134228", "pseudo_increased_physical_damage" }, { "stat_2974417149", "pseudo_increased_spell_damage" }, { "stat_3141070085", "pseudo_increased_elemental_damage" },
            { "stat_2231156303", "pseudo_increased_lightning_damage" }, { "stat_3291658075", "pseudo_increased_cold_damage" }, { "stat_3962278098", "pseudo_increased_fire_damage" },
            { "stat_4208907162", "pseudo_increased_lightning_damage_with_attack_skills" }, { "stat_860668586", "pseudo_increased_cold_damage_with_attack_skills" }, { "stat_2468413380", "pseudo_increased_fire_damage_with_attack_skills" }, { "stat_387439868", "pseudo_increased_elemental_damage_with_attack_skills" },
            { "stat_960081730", "pseudo_adds_physical_damage" }, { "stat_1334060246", "pseudo_adds_lightning_damage" }, { "stat_2387423236", "pseudo_adds_cold_damage" }, { "stat_321077055", "pseudo_adds_fire_damage" }, { "stat_3531280422", "pseudo_adds_chaos_damage" },
            { "stat_3032590688", "pseudo_adds_physical_damage_to_attacks" }, { "stat_1754445556", "pseudo_adds_lightning_damage_to_attacks" }, { "stat_4067062424", "pseudo_adds_cold_damage_to_attacks" }, { "stat_1573130764", "pseudo_adds_fire_damage_to_attacks" }, { "stat_674553446", "pseudo_adds_chaos_damage_to_attacks" },
            { "stat_2435536961", "pseudo_adds_physical_damage_to_spells" }, { "stat_2831165374", "pseudo_adds_lightning_damage_to_spells" }, { "stat_2469416729", "pseudo_adds_cold_damage_to_spells" }, { "stat_1133016593", "pseudo_adds_fire_damage_to_spells" }, { "stat_2300399854", "pseudo_adds_chaos_damage_to_spells" },
            { "stat_3325883026", "pseudo_total_life_regen" }, { "stat_836936635", "pseudo_percent_life_regen" }, { "stat_789117908", "pseudo_increased_mana_regen" }
        };

        internal static Dictionary<string, string> lInherit = new Dictionary<string, string>()
        {
            { "Weapons","weapon" }, { "Quivers","armour.quiver" }, { "Armours","armour" },
            { "Amulets","accessory.amulet" }, { "Rings","accessory.ring" }, { "Belts","accessory.belt" }, /* accessory */
            { "Jewels","jewel" }, { "Flasks","flask" }, { "DivinationCards","card" }, { "Prophecies","prophecy" }, { "Gems","gem" },
            { "Currency","currency" },  { "Maps","map" }, { "MapFragments","map" }
        };

        internal static Dictionary<string, string> lRarity = new Dictionary<string, string>()
        {
            { Unique, "unique"}, { Rare, "rare"}, { Magic, "magic"}, { Normal, "normal"}
        };

        internal static Dictionary<string, string> lExchangeCurrency = new Dictionary<string, string> {
                { "Ancient Orb", "ancient-orb"}, { "Engineer's Orb", "engineers-orb"}, { "Orb of Chance", "chance"}, { "Vaal Orb", "vaal"}, { "Orb of Alteration", "alt"},
                { "Harbinger's Orb", "harbingers-orb"}, { "Orb of Annulment", "orb-of-annulment"}, { "Orb of Binding", "orb-of-binding"}, { "Divine Orb", "divine"}, { "Chromatic Orb", "chrom"},
                { "Orb of Fusing", "fuse"}, { "Orb of Alchemy", "alch"}, { "Eternal Orb", "ete"}, { "Exalted Orb", "exa"}, { "Orb of Scouring", "scour"},
                { "Jeweller's Orb", "jew"}, { "Orb of Horizons", "orb-of-horizons"}, { "Orb of Transmutation", "tra"},  { "Regal Orb", "regal"},  { "Blessed Orb", "blessed"},
                { "Chaos Orb", "chaos"}, { "Mirror of Kalandra", "mir"}, { "Orb of Augmentation", "aug"}, { "Orb of Regret", "regret"}, { "Gemcutter's Prism", "gcp"},
                { "Glassblower's Bauble", "ba"}, { "Silver Coin", "silver"}, { "Stacked Deck", "stacked-deck"}, { "Scroll of Wisdom", "wis"}, { "Portal Scroll", "port"}, { "Cartographer's Chisel", "chisel"},
                { "Simple Sextant", "apprentice-sextant"}, { "Prime Sextant", "journeyman-sextant"}, { "Awakened Sextant", "master-sextant"},
                { "Hollow Fossil", "hollow-fossil"}, { "Scorched Fossil", "scorched-fossil"}, { "Metallic Fossil", "metallic-fossil"}, { "Gilded Fossil", "gilded-fossil"}, { "Encrusted Fossil", "encrusted-fossil"},
                { "Corroded Fossil", "corroded-fossil"}, { "Prismatic Fossil", "prismatic-fossil"}, { "Fractured Fossil", "fractured-fossil"},{ "Jagged Fossil", "jagged-fossil"}, { "Lucent Fossil", "lucent-fossil"},
                { "Glyphic Fossil", "glyphic-fossil"}, { "Bound Fossil", "bound-fossil"}, { "Tangled Fossil", "tangled-fossil"},   { "Faceted Fossil", "faceted-fossil"}, { "Pristine Fossil", "pristine-fossil"},
                { "Perfect Fossil", "perfect-fossil"},  { "Enchanted Fossil", "enchanted-fossil"}, { "Aetheric Fossil", "aetheric-fossil"}, { "Shuddering Fossil", "shuddering-fossil"}, { "Dense Fossil", "dense-fossil"},
                { "Frigid Fossil", "frigid-fossil"}, { "Sanctified Fossil", "sanctified-fossil"}, { "Serrated Fossil", "serrated-fossil"}, { "Aberrant Fossil", "aberrant-fossil"},{ "Bloodstained Fossil", "bloodstained-fossil"},
                { "Splinter of Uul-Netol", "splinter-uul"}, { "Splinter of Esh", "splinter-esh"}, { "Splinter of Xoph", "splinter-xoph"}, { "Splinter of Chayula", "splinter-chayula"}, { "Splinter of Tul", "splinter-tul"},
                { "Blessing of Uul-Netol", "blessing-uul-netol"}, { "Blessing of Esh", "blessing-esh"}, { "Blessing of Xoph", "blessing-xoph"}, { "Blessing of Chayula", "blessing-chayula"}, { "Blessing of Tul", "blessing-tul"},
                { "Timeless Vaal Splinter", "timeless-vaal-splinter"}, { "Timeless Eternal Empire Splinter", "timeless-eternal-empire-splinter"}, { "Timeless Karui Splinter", "timeless-karui-splinter"}, { "Timeless Templar Splinter", "timeless-templar-splinter"}, { "Timeless Maraketh Splinter", "timeless-maraketh-splinter"},
                { "Timeless Vaal Emblem", "timeless-vaal-emblem"}, { "Timeless Eternal Emblem", "timeless-eternal-emblem"}, { "Timeless Karui Emblem", "timeless-karui-emblem"}, { "Timeless Templar Emblem", "timeless-templar-emblem"}, { "Timeless Maraketh Emblem", "timeless-maraketh-emblem"},
                { "Blacksmith's Whetstone", "whe"}, { "Armourer's Scrap", "scr"}, { "Annulment Shard", "annulment-shard"}, { "Mirror Shard", "mirror-shard"}, { "Exalted Shard", "exalted-shard"},
                { "Binding Shard", "binding-shard"},{ "Horizon Shard", "horizon-shard"}, { "Harbinger's Shard", "harbingers-shard"}, { "Engineer's Shard", "engineers-shard"}, { "Ancient Shard", "ancient-shard"},
                { "Chaos Shard", "chaos-shard"},{ "Regal Shard", "regal-shard"}, { "Perandus Coin", "p"}, { "Turbulent Catalyst", "turbulent-catalyst"}, { "Imbued Catalyst", "imbued-catalyst" },
                { "Abrasive Catalyst", "abrasive-catalyst" }, { "Tempering Catalyst", "tempering-catalyst" }, { "Fertile Catalyst", "fertile-catalyst" }, { "Prismatic Catalyst", "prismatic-catalyst"},
                { "Intrinsic Catalyst", "intrinsic-catalyst" }
            };
    }
}