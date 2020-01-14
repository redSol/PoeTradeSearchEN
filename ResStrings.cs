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
        internal static string PoePriceApi = "https://www.poeprices.info/api?l=Metamorph&i=";

        internal static byte ServerLang = 1;
        internal static string ServerType = "";

        internal static string ModText = "";

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
        internal const string Watchstone = "Watchstone";

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

        internal static Dictionary<string, string> lGemQualityProperties = new Dictionary<string, string>()
        {
            { "Abyssal Cry" , " 20% increased Skill Effect Duration (1% per 1% Q)" },
            { "Added Chaos Damage Support" , " 10% increased Chaos Damage (0.5% per 1% Q)" },
            { "Added Cold Damage Support" , " 10% increased Cold Damage (0.5% per 1% Q)" },
            { "Added Fire Damage Support" , " 10% increased Fire Damage (0.5% per 1% Q)" },
            { "Added Lightning Damage Support" , " 10% increased Lightning Damage (0.5% per 1% Q)" },
            { "Additional Accuracy Support" , " 20% increased Accuracy Rating (1% per 1% Q)" },
            { "Advanced Traps Support" , " 10% increased Trap Damage (0.5% per 1% Q)" },
            { "Ancestral Call Support" , " 10% increased Attack Speed (0.5% per 1% Q)" },
            { "Ancestral Protector" , " 20% increased Totem Damage (1% per 1% Q)" },
            { "Ancestral Warchief" , " 20% increased Totem Damage (1% per 1% Q)" },
            { "Anger" , " 40% increased Area of Effect (2% per 1% Q)" },
            { "Animate Guardian" , " Minions have 40% increased Movement Speed (2% per 1% Q)" },
            { "Animate Weapon" , " Minions have 40% increased Movement Speed (2% per 1% Q)" },
            { "Arc" , " 10% chance to Shock enemies (0.5% per 1% Q)" },
            { "Arcane Surge Support" , " 10% increased Spell Damage (0.5% per 1% Q)" },
            { "Arctic Armour" , " 20% increased Skill Effect Duration (1% per 1% Q)" },
            { "Arctic Breath" , " 10% increased Area of Effect (0.5% per 1% Q)" },
            { "Armageddon Brand" , " 10% increased Cast Speed (0.5% per 1% Q)" },
            { "Assassin's Mark" , " Cursed enemies have a 10% chance to grant a Power Charge when slain (0.5% per 1% Q)" },
            { "Ball Lightning" , " 20% increased Lightning Damage (1% per 1% Q)" },
            { "Bane" , " Applied Curses have 10% increased Effect (0.5% per 1% Q)" },
            { "Barrage" , " 10% increased Projectile Damage (0.5% per 1% Q)" },
            { "Bear Trap" , " 20% increased Physical Damage (1% per 1% Q)" },
            { "Berserk" , " 20% increased Attack Damage (1% per 1% Q)" },
            { "Blade Flurry" ,  " 10% increased Attack Speed (0.5% per 1% Q)" },
            { "Blade Vortex" , " 10% increased Area of Effect (0.5% per 1% Q)" },
            { "Bladefall" , " 10% increased Area of Effect (0.5% per 1% Q)" },
            { "Bladestorm" , " 20% increased Skill Effect Duration (1% per 1% Q)" },
            { "Blasphemy Support" , " 10% increased Effect of Supported Curses (0.5% per 1% Q)" },
            { "Blast Rain" , " 10% increased Area of Effect (0.5% per 1% Q)" },
            { "Blastchain Mine Support" , " 10% increased Mine Throwing Speed (0.5% per 1% Q)" },
            { "Blight" , " 10% increased Area of Effect (0.5% per 1% Q)" },
            { "Blind Support" , " 20% increased Blinding duration (1% per 1% Q)" },
            { "Blink Arrow" , " 30% increased Arrow Speed (1.5% per 1% Q)" },
            { "Block Chance Reduction Support" , " 5% reduced Enemy Block Chance (0.25% per 1% Q)" },
            { "Blood and Sand" , " 10% increased Cooldown Recovery Speed (0.5% per 1% Q)" },
            { "Blood Magic Support" , " 10% reduced Mana Cost (0.5% per 1% Q)" },
            { "Blood Rage" , " 5% increased Attack Speed (0.25% per 1% Q)" },
            { "Bloodlust Support" , " 10% increased Melee Damage against Bleeding Enemies (0.5% per 1% Q)" },
            { "Bodyswap" , " 10% increased Cast Speed (0.5% per 1% Q)" },
            { "Bone Offering" , " 10% increased Skill Effect Duration (0.5% per 1% Q)" },
            { "Bonechill Support" , " 20% increased Chill Duration on Enemies (1% per 1% Q)" },
            { "Brand Recall" , " Brands gain 20% increased Attachment Range (1% per 1% Q)" },
            { "Brutality Support" , " 10% increased Physical Damage (0.5% per 1% Q)" },
            { "Burning Arrow" , " 60% increased Ignite Duration on enemies (3% per 1% Q)" },
            { "Burning Damage Support" , " 10% increased Burning Damage (0.5% per 1% Q)" },
            { "Cast On Critical Strike Support" , " 20% increased Attack Critical Strike Chance (1% per 1% Q)" },
            { "Cast on Death Support" , " 60% increased Area of Effect while Dead (3% per 1% Q)" },
            { "Cast on Melee Kill Support" , " 10% increased Attack Damage (0.5% per 1% Q)" },
            { "Cast when Damage Taken Support" , " 10% increased Damage (0.5% per 1% Q)" },
            { "Cast when Stunned Support" , " 10% increased Damage (0.5% per 1% Q)" },
            { "Cast while Channelling Support" , " Supported Channelling Skills deal 10% increased Damage (0.5% per 1% Q)" },
            { "Caustic Arrow" , " 10% increased Area of Effect (0.5% per 1% Q)" },
            { "Chain Hook" , " 10% increased Area of Effect (0.5% per 1% Q)" },
            { "Chain Support" , " 20% increased Projectile Speed (1% per 1% Q)" },
            { "Chance to Bleed Support" , " Supported Attacks deal 10% increased Damage with Bleeding (0.5% per 1% Q)" },
            { "Chance to Flee Support" , " 20% chance to Cause Monsters to Flee (1% per 1% Q)" },
            { "Charged Dash" , " 10% increased Attack Speed (0.5% per 1% Q)" },
            { "Charged Mines Support" , " 10% increased Mine Damage (0.5% per 1% Q)" },
            { "Charged Traps Support" , " 10% increased Trap Damage (0.5% per 1% Q)" },
            { "Clarity" , " 40% increased Area of Effect (2% per 1% Q)" },
            { "Cleave" , " 10% increased Attack Speed (0.5% per 1% Q)" },
            { "Close Combat Support" , " 10% increased Melee Damage (0.5% per 1% Q)" },
            { "Cluster Traps Support" , " 10% increased Trap Damage (0.5% per 1% Q)" },
            { "Cobra Lash" , " 30% increased Critical Strike Chance (1.5% per 1% Q)" },
            { "Cold Penetration Support" , " 10% increased Cold Damage (0.5% per 1% Q)" },
            { "Cold Snap" , " 10% increased Area of Effect (0.5% per 1% Q)" },
            { "Cold to Fire Support" , " 10% increased Cold Damage 10% increased Fire Damage (0.5% per 1% Q)" },
            { "Combustion Support" , " 10% increased Fire Damage (0.5% per 1% Q)" },
            { "Concentrated Effect Support" , " 10% increased Area Damage (0.5% per 1% Q)" },
            { "Conductivity" , " Shocks on Cursed enemies have 20% increased Duration (1% per 1% Q)" },
            { "Consecrated Path" , " 10% increased Area of Effect (0.5% per 1% Q)" },
            { "Contagion" , " 10% increased Area of Effect (0.5% per 1% Q)" },
            { "Controlled Destruction Support" , " 10% increased Spell Damage (0.5% per 1% Q)" },
            { "Conversion Trap" , " 20% increased Skill Effect Duration (1% per 1% Q)" },
            { "Convocation" , " 20% increased Skill Effect Duration 20% increased Cooldown Recovery Speed (1% per 1% Q)" },
            { "Cremation" , " 20% increased Fire Damage (1% per 1% Q)" },
            { "Culling Strike Support" , " 10% increased Attack Speed 10% increased Cast Speed (0.5% per 1% Q)" },
            { "Curse On Hit Support" , " 10% increased Effect of Supported Curses (0.5% per 1% Q)" },
            { "Cyclone" , " 10% increased Area of Effect (0.5% per 1% Q)" },
            { "Damage on Full Life Support" , " 10% increased Damage (0.5% per 1% Q)" },
            { "Dark Pact" , " 10% increased Area of Effect (0.5% per 1% Q)" },
            { "Dash" , " 10% increased Cooldown Recovery Speed (0.5% per 1% Q)" },
            { "Deadly Ailments Support" , " 10% increased Damage over Time (0.5% per 1% Q)" },
            { "Deathmark Support" , " Minions from Supported Skills deal 10% increased Damage (0.5% per 1% Q)" },
            { "Decay Support" , " 10% increased Chaos Damage (0.5% per 1% Q)" },
            { "Decoy Totem" , " 20% increased totem life (1% per 1% Q)" },
            { "Desecrate" , " 20% increased Cast Speed (1% per 1% Q)" },
            { "Despair" , " Cursed enemies take 10% increased Damage from Damage Over Time effects (0.5% per 1% Q)" },
            { "Determination" , " 40% increased Area of Effect (2% per 1% Q)" },
            { "Detonate Dead" , " 10% increased Cast Speed (0.5% per 1% Q)" },
            { "Detonate Mines" , " Mines have 20% increased Detonation Speed (1% per 1% Q)" },
            { "Devouring Totem" , " 20% increased totem life (1% per 1% Q)" },
            { "Discharge" , " 10% increased Area of Effect (0.5% per 1% Q)" },
            { "Discipline" , " 40% increased Area of Effect (2% per 1% Q)" },
            { "Divine Ire" , " 10% increased Area of Effect (0.5% per 1% Q)" },
            { "Dominating Blow" , " Minions deal 20% increased Damage (1% per 1% Q)" },
            { "Double Strike" , " 10% increased Attack Speed (0.5% per 1% Q)" },
            { "Dread Banner" , " 10% increased effect of Aura (0.5% per 1% Q)" },
            { "Dual Strike" , " 20% increased Critical Strike Chance +10% to Critical Strike Multiplier (1% / 0.5% per 1% Q)" },
            { "Earthquake" , " 20% increased Damage (1% per 1% Q)" },
            { "Efficacy Support" , " 10% increased Damage over Time (0.5% per 1% Q)" },
            { "Elemental Army Support" , " Minions from Supported Skills have +2% to all maximum Elemental Resistances (0.1% per 1% Q)" },
            { "Elemental Damage with Attacks Support" , " 10% increased Elemental Damage with Attack Skills (0.5% per 1% Q)" },
            { "Elemental Focus Support" , " 10% increased Elemental Damage (0.5% per 1% Q)" },
            { "Elemental Hit" , " 20% increased Elemental Damage (1% per 1% Q)" },
            { "Elemental Proliferation Support" , " 10% increased Duration of Elemental Ailments on Enemies (0.5% per 1% Q)" },
            { "Elemental Weakness" , " Cursed enemies have -5% to Elemental Resistances (-0.25% per 1% Q)" },
            { "Empower Support" , " This Gem gains 100% increased Experience (5% per 1% Q)" },
            { "Endurance Charge on Melee Stun Support" , " 20% increased Stun Duration on Enemies (1% per 1% Q)" },
            { "Enduring Cry" , " 60% increased Area of Effect (3% per 1% Q)" },
            { "Energy Leech Support" , " 10% increased Damage while Leeching Energy Shield (0.5% per 1% Q)" },
            { "Enfeeble" , " Cursed enemies have 4% reduced Accuracy Rating Cursed enemies have 10% reduced Critical Strike Chance (0.2% / 0.5% per 1% Q)" },
            { "Enhance Support" , " This Gem gains 100% increased Experience (5% per 1% Q)" },
            { "Enlighten Support" , " This Gem gains 100% increased Experience (5% per 1% Q)" },
            { "Essence Drain" , " 20% increased Chaos Damage (1% per 1% Q)" },
            { "Ethereal Knives" , " 20% increased Projectile Speed (1% per 1% Q)" },
            { "Explosive Arrow" , " 20% chance to Ignite enemies (1% per 1% Q)" },
            { "Explosive Trap" , " 10% increased Area of Effect (0.5% per 1% Q)" },
            { "Faster Attacks Support" , " 10% increased Attack Speed (0.5% per 1% Q)" },
            { "Faster Casting Support" , " 10% increased Cast Speed (0.5% per 1% Q)" },
            { "Faster Projectiles Support" , " 10% increased Attack Speed 10% increased Cast Speed (0.5% per 1% Q)" },
            { "Feeding Frenzy Support" , " Feeding Frenzy base Duration is 1 second (0.05 per 1% Q)" },
            { "Fire Penetration Support" , " 10% increased Fire Damage (0.5% per 1% Q)" },
            { "Fire Trap" , " 20% increased Fire Damage (1% per 1% Q)" },
            { "Fireball" , " 10% chance to Ignite enemies (0.5% per 1% Q)" },
            { "Firestorm" , " 20% increased Damage (1% per 1% Q)" },
            { "Flame Dash" , " 20% increased Cooldown Recovery Speed (1% per 1% Q)" },
            { "Flame Surge" , " 10% increased Cast Speed (0.5% per 1% Q)" },
            { "Flameblast" , " 20% increased Damage (1% per 1% Q)" },
            { "Flamethrower Trap" , " 20% increased Fire Damage (1% per 1% Q)" },
            { "Flammability" , " Ignite on Cursed enemies has 10% increased Duration (0.5% per 1% Q)" },
            { "Flesh and Stone" , " 10% increased Cooldown Recovery Speed (0.5% per 1% Q)" },
            { "Flesh Offering" , " 10% increased Skill Effect Duration (0.5% per 1% Q)" },
            { "Flicker Strike" , " 5% chance to gain a Frenzy Charge on Hit (0.25% per 1% Q)" },
            { "Fork Support" , " 10% increased Projectile Damage (0.5% per 1% Q)" },
            { "Fortify Support" , " 10% increased Attack Damage (0.5% per 1% Q)" },
            { "Freezing Pulse" , " 40% increased Projectile Speed (2% per 1% Q)" },
            { "Frenzy" , " 10% increased Attack Speed (0.5% per 1% Q)" },
            { "Frost Blades" , " 20% increased Damage 20% increased Projectile Speed (1% per 1% Q)" },
            { "Frost Bomb" , " 20% increased Cold Damage (1% per 1% Q)" },
            { "Frost Wall" , " 20% increased Skill Effect Duration (1% per 1% Q)" },
            { "Frostbite" , " Freezes on Cursed enemies have 20% increased Duration (1% per 1% Q)" },
            { "Frostblink" , " 20% increased Effect of Chill (1% per 1% Q)" },
            { "Frostbolt" , " 20% increased Cold Damage (1% per 1% Q)" },
            { "Generosity Support" , " 40% increased Aura Area of Effect (2% per 1% Q)" },
            { "Glacial Cascade" , " 20% increased Damage (1% per 1% Q)" },
            { "Glacial Hammer" , " 40% increased Chill Duration on enemies 20% increased Freeze Duration on enemies (2% / 1% per 1% Q)" },
            { "Grace" , " 40% increased Area of Effect (2% per 1% Q)" },
            { "Greater Multiple Projectiles Support" , " 10% increased Attack Speed 10% increased Cast Speed (0.5% per 1% Q)" },
            { "Ground Slam" , " 20% increased Stun Duration on enemies 10% increased Area of Effect (1% / 0.5% per 1% Q)" },
            { "Haste" , " 40% increased Area of Effect (2% per 1% Q)" },
            { "Hatred" , " 40% increased Area of Effect (2% per 1% Q)" },
            { "Heavy Strike" , " 20% increased Stun Duration on enemies 20% increased Damage (1% per 1% Q)" },
            { "Herald of Agony" , " 20% increased Minion Movement Speed (1% per 1% Q)" },
            { "Herald of Ash" , " 15% increased Fire Damage (0.75% per 1% Q)" },
            { "Herald of Ice" , " 15% increased Cold Damage (0.75% per 1% Q)" },
            { "Herald of Purity" , " 20% increased Minion Movement Speed (1% per 1% Q)" },
            { "Herald of Thunder" , " 15% increased Lightning Damage (0.75% per 1% Q)" },
            { "High-Impact Mine Support" , " 10% increased Mine Throwing Speed (0.5% per 1% Q)" },
            { "Holy Flame Totem" , " 20% increased Projectile Speed (1% per 1% Q)" },
            { "Hypothermia Support" , " 30% increased Chill Duration on Enemies (1.5% per 1% Q)" },
            { "Ice Bite Support" , " 20% increased Damage with Hits against Frozen Enemies (1% per 1% Q)" },
            { "Ice Crash" , " 20% increased Damage (1% per 1% Q)" },
            { "Ice Nova" , " 10% increased Area of Effect (0.5% per 1% Q)" },
            { "Ice Shot" , " 20% increased Cold Damage (1% per 1% Q)" },
            { "Ice Spear" , " 40% increased Projectile Speed (2% per 1% Q)" },
            { "Ice Trap" , " 10% increased Area of Effect (0.5% per 1% Q)" },
            { "Icicle Mine" , " 20% increased Projectile Damage (1% per 1% Q)" },
            { "Ignite Proliferation Support" , " 10% increased Fire Damage (0.5% per 1% Q)" },
            { "Immolate Support" , " 10% increased Fire Damage (0.5% per 1% Q)" },
            { "Immortal Call" , " 20% increased Skill Effect Duration (1% per 1% Q)" },
            { "Impale Support" , " Supported Attacks have 10% increased Impale Effect (0.5% per 1% Q)" },
            { "Incinerate" , " 20% increased Fire Damage (1% per 1% Q)" },
            { "Increased Area of Effect Support" , " 10% increased Area Damage (0.5% per 1% Q)" },
            { "Increased Critical Damage Support" , " +15% to Critical Strike Multiplier (0.75% per 1% Q)" },
            { "Increased Critical Strikes Support" , " 20% increased Critical Strike Chance (1% per 1% Q)" },
            { "Increased Duration Support" , " 10% increased Skill Effect Duration (0.5% per 1% Q)" },
            { "Infernal Blow" , " 10% increased Area of Effect (0.5% per 1% Q)" },
            { "Infernal Legion Support" , " Minions from Supported Skills take 20% reduced Fire Damage (1% per 1% Q)" },
            { "Infused Channelling Support" , " Gain Infusion after Channelling a Supported Skill for -0.4 seconds (-0.02 per 1% Q)" },
            { "Innervate Support" , " 30% increased Shock Duration on Enemies (1.5% per 1% Q)" },
            { "Inspiration Support" , " 20% increased Inspiration Charge Duration (1% per 1% Q)" },
            { "Intensify Support" , " 10% increased Area Damage (0.5% per 1% Q)" },
            { "Iron Grip Support" , " 10% increased Projectile Damage (0.5% per 1% Q)" },
            { "Iron Will Support" , " 10% increased Spell Damage (0.5% per 1% Q)" },
            { "Item Quantity Support" , " 7% increased Quantity of Items Dropped by Enemies Slain (0.35% per 1% Q)" },
            { "Item Rarity Support" , " 10% increased Rarity of Items Dropped by Enemies Slain (0.5% per 1% Q)" },
            { "Kinetic Blast" , " 10% increased Area of Effect (0.5% per 1% Q)" },
            { "Knockback Support" , " 10% chance to Knock Enemies Back on hit (0.5% per 1% Q)" },
            { "Lacerate" , " 10% increased Area of Effect (0.5% per 1% Q)" },
            { "Lancing Steel" , " 10% chance to Impale Enemies on Hit (0.5% per 1% Q)" },
            { "Leap Slam" , " 20% increased Stun Duration on enemies (1% per 1% Q)" },
            { "Less Duration Support" , " 10% reduced Skill Effect Duration (0.5% per 1% Q)" },
            { "Lesser Multiple Projectiles Support" , " 10% increased Attack Speed 10% increased Cast Speed (0.5% per 1% Q)" },
            { "Lesser Poison Support" , " 10% increased Damage with Poison (0.5% per 1% Q)" },
            { "Life Gain on Hit Support" , " +10 Life gained for each Enemy hit by Attacks (0.5 per 1% Q)" },
            { "Life Leech Support" , " 10% increased Damage while Leeching Life (0.5% per 1% Q)" },
            { "Lightning Arrow" , " 20% chance to Shock enemies (1% per 1% Q)" },
            { "Lightning Penetration Support" , " 10% increased Lightning Damage (0.5% per 1% Q)" },
            { "Lightning Spire Trap" , " 20% chance to Shock enemies (1% per 1% Q)" },
            { "Lightning Strike" , " 20% increased Damage 20% increased Projectile Speed (1% per 1% Q)" },
            { "Lightning Tendrils" , " 20% increased Lightning Damage (1% per 1% Q)" },
            { "Lightning Trap" , " 20% increased Lightning Damage 10% increased Effect of Shock (1% / 0.5% per 1% Q)" },
            { "Lightning Warp" , " 20% increased Cast Speed (1% per 1% Q)" },
            { "Magma Orb" , " 20% increased Damage (1% per 1% Q)" },
            { "Maim Support" , " 10% increased Physical Damage (0.5% per 1% Q)" },
            { "Malevolence" , " 40% increased Area of Effect (2% per 1% Q)" },
            { "Mana Leech Support" , " 10% increased Damage while Leeching Mana (0.5% per 1% Q)" },
            { "Meat Shield Support" , " Minions from Supported Skills have 5% additional Physical Damage Reduction (0.25% per 1% Q)" },
            { "Melee Physical Damage Support" , " 10% increased Melee Physical Damage (0.5% per 1% Q)" },
            { "Melee Splash Support" , " 10% increased Area of Effect (0.5% per 1% Q)" },
            { "Minefield Support" , " 10% increased Mine Throwing Speed (0.5% per 1% Q)" },
            { "Minion Damage Support" , " Minions from Supported Skills deal 15% increased Damage (0.75% per 1% Q)" },
            { "Minion Life Support" , " 15% increased Minion maximum Life (0.75% per 1% Q)" },
            { "Minion Speed Support" , " 10% increased Minion Movement Speed (0.5% per 1% Q)" },
            { "Mirage Archer Support" , " 10% increased Attack Damage (0.5% per 1% Q)" },
            { "Mirror Arrow" , " 30% increased Arrow Speed (1.5% per 1% Q)" },
            { "Molten Shell" , " 20% increased Skill Effect Duration (1% per 1% Q)" },
            { "Molten Strike" , " 20% increased Fire Damage (1% per 1% Q)" },
            { "Multiple Totems Support" , " 20% increased Totem Placement speed (1% per 1% Q)" },
            { "Multiple Traps Support" , " 20% increased Trap Trigger Area of Effect (1% per 1% Q)" },
            { "Multistrike Support" , " 10% increased Melee Physical Damage (0.5% per 1% Q)" },
            { "Nightblade Support" , " 20% increased Critical Strike Chance (1% per 1% Q)" },
            { "Onslaught Support" , " 5% increased Attack and Cast Speed (0.25% per 1% Q)" },
            { "Orb of Storms" , " 20% increased Lightning Damage (1% per 1% Q)" },
            { "Perforate" , " 10% increased Area of Effect (0.5% per 1% Q)" },
            { "Pestilent Strike" , " +10% to Damage over Time Multiplier for Poison (0.5% per 1% Q)" },
            { "Phase Run" , " 10% increased Movement Speed (0.5% per 1% Q)" },
            { "Physical to Lightning Support" , " 10% increased Physical Damage 10% increased Lightning Damage (0.5% per 1% Q)" },
            { "Pierce Support" , " 10% increased Projectile Damage (0.5% per 1% Q)" },
            { "Plague Bearer" , " 10% increased Area of Effect (0.5% per 1% Q)" },
            { "Poacher's Mark" , " Cursed enemies have a 10% chance to grant a Frenzy Charge when slain (0.5% per 1% Q)" },
            { "Point Blank Support" , " 10% increased Projectile Damage (0.5% per 1% Q)" },
            { "Poison Support" , " 10% increased Damage with Poison (0.5% per 1% Q)" },
            { "Portal" , " 60% increased Cast Speed (3% per 1% Q)" },
            { "Power Charge On Critical Support" , " 20% increased Critical Strike Chance (1% per 1% Q)" },
            { "Power Siphon" , " 20% increased Damage (1% per 1% Q)" },
            { "Precision" , " 40% increased Area of Effect (2% per 1% Q)" },
            { "Pride" , " 40% increased Area of Effect (2% per 1% Q)" },
            { "Projectile Weakness" , " Cursed enemies take 10% increased Damage from Projectile Hits (0.5% per 1% Q)" },
            { "Pulverise Support" , " 10% increased Area Damage (0.5% per 1% Q)" },
            { "Puncture" , " Bleeding inflicted by this Skill deals Damage 10% faster (0.5% per 1% Q)" },
            { "Punishment" , " Cursed enemies grant 5% increased Attack Speed on Melee hit (0.25% per 1% Q)" },
            { "Purifying Flame" , " 10% increased Area of Effect (0.5% per 1% Q)" },
            { "Purity of Elements" , " 40% increased Area of Effect (2% per 1% Q)" },
            { "Purity of Fire" , " 40% increased Area of Effect (2% per 1% Q)" },
            { "Purity of Ice" , " 40% increased Area of Effect (2% per 1% Q)" },
            { "Purity of Lightning" , " 40% increased Area of Effect (2% per 1% Q)" },
            { "Pyroclast Mine" , " 20% increased Area of Effect (1% per 1% Q)" },
            { "Rage Support" , " 10% increased Attack Damage (0.5% per 1% Q)" },
            { "Rain of Arrows" , " 10% increased Area of Effect (0.5% per 1% Q)" },
            { "Raise Spectre" , " 20% increased Minion Movement Speed (1% per 1% Q)" },
            { "Raise Zombie" , " 20% increased Minion Maximum Life 20% increased Minion Movement Speed (1% per 1% Q)" },
            { "Rallying Cry" , " 30% increased Skill Effect Duration (1.5% per 1% Q)" },
            { "Ballista Totem Support" , " 20% increased Totem Placement speed (1% per 1% Q)" },
            { "Reave" , " 10% increased Attack Speed (0.5% per 1% Q)" },
            { "Reckoning" , " 10% increased Area of Effect (0.5% per 1% Q)" },
            { "Rejuvenation Totem" , " 60% increased Aura Area of Effect (3% per 1% Q)" },
            { "Righteous Fire" , " 20% increased Burning Damage (1% per 1% Q)" },
            { "Riposte" , " 20% increased Damage (1% per 1% Q)" },
            { "Ruthless Support" , " 10% increased Attack Damage (0.5% per 1% Q)" },
            { "Scorching Ray" , " 10% increased beam length (0.5% per 1% Q)" },
            { "Scourge Arrow" , " 20% increased Projectile Speed (1% per 1% Q)" },
            { "Searing Bond" , " 20% increased totem life (1% per 1% Q)" },
            { "Seismic Trap" , " 20% increased Physical Damage (1% per 1% Q)" },
            { "Shattering Steel" , " 20% increased Impale Effect (1% per 1% Q)" },
            { "Shield Charge" , " 20% increased Movement Speed (1% per 1% Q)" },
            { "Shock Nova" , " 40% increased Shock Duration on enemies (2% per 1% Q)" },
            { "Shockwave Support" , " 10% increased Melee Damage (0.5% per 1% Q)" },
            { "Shockwave Totem" , " 20% increased totem life (1% per 1% Q)" },
            { "Shrapnel Shot" , " 10% increased Area of Effect (0.5% per 1% Q)" },
            { "Siege Ballista" , " 20% increased Totem Placement speed (1% per 1% Q)" },
            { "Siphoning Trap" , " 20% increased Effect of Chill (1% per 1% Q)" },
            { "Slower Projectiles Support" , " 10% increased Projectile Damage (0.5% per 1% Q)" },
            { "Smite" , " 10% increased Area of Effect (0.5% per 1% Q)" },
            { "Smoke Mine" , " 40% increased Area of Effect (2% per 1% Q)" },
            { "Soulrend" , " 20% increased Chaos Damage (1% per 1% Q)" },
            { "Spark" , " 20% increased Projectile Speed (1% per 1% Q)" },
            { "Spectral Shield Throw" , " 40% increased Projectile Speed (2% per 1% Q)" },
            { "Spectral Throw" , " 10% increased Attack Speed (0.5% per 1% Q)" },
            { "Spell Cascade Support" , " 10% increased Area of Effect (0.5% per 1% Q)" },
            { "Spell Echo Support" , " 10% increased Spell Damage (0.5% per 1% Q)" },
            { "Spell Totem Support" , " 20% increased Totem Placement speed (1% per 1% Q)" },
            { "Spirit Offering" , " 10% increased Skill Effect Duration (0.5% per 1% Q)" },
            { "Split Arrow" , " 10% increased Attack Speed (0.5% per 1% Q)" },
            { "Static Strike" , " 20% increased Skill Effect Duration (1% per 1% Q)" },
            { "Steelskin" , " 10% increased Cooldown Recovery Speed (0.5% per 1% Q)" },
            { "Storm Brand" , " 10% increased Cast Speed (0.5% per 1% Q)" },
            { "Storm Burst" , " 10% increased Area of Effect (0.5% per 1% Q)" },
            { "Storm Call" , " 10% increased Area of Effect (0.5% per 1% Q)" },
            { "Stormblast Mine" , " 10% chance to Shock enemies 10% increased Effect of Shock (0.5% per 1% Q)" },
            { "Stun Support" , " 30% increased Stun Duration on Enemies (1.5% per 1% Q)" },
            { "Summon Carrion Golem" , " 20% increased Minion Maximum Life Minions deal 20% increased Damage (1% per 1% Q)" },
            { "Summon Chaos Golem" , " 20% increased Minion Maximum Life Minions deal 20% increased Damage (1% per 1% Q)" },
            { "Summon Flame Golem" , " 20% increased Minion Maximum Life Minions deal 20% increased Damage (1% per 1% Q)" },
            { "Summon Holy Relic" , " Minions have 10% increased Area of Effect (0.5% per 1% Q)" },
            { "Summon Ice Golem" , " 20% increased Minion Maximum Life Minions deal 20% increased Damage (1% per 1% Q)" },
            { "Summon Lightning Golem" , " 20% increased Minion Maximum Life Minions deal 20% increased Damage (1% per 1% Q)" },
            { "Summon Phantasm Support" , " 10% chance to Summon a Phantasm when Supported Skills, or Non-Phantasm Minions from Supported Skills, deal a Killing Blow (0.5% per 1% Q)" },
            { "Summon Raging Spirit" , " 20% increased Minion Movement Speed (1% per 1% Q)" },
            { "Summon Skeletons" , " Minions deal 20% increased Damage (1% per 1% Q)" },
            { "Summon Skitterbots" , " 40% increased Minion Movement Speed (2% per 1% Q)" },
            { "Summon Stone Golem" , " 20% increased Minion Maximum Life Minions deal 20% increased Damage (1% per 1% Q)" },
            { "Sunder" , " 10% increased Area of Effect (0.5% per 1% Q)" },
            { "Sweep" , " 10% increased Area of Effect (0.5% per 1% Q)" },
            { "Swift Affliction Support" , " 10% increased Damage over Time (0.5% per 1% Q)" },
            { "Swift Assembly Support" , " 10% increased Mine Throwing Speed 10% increased Trap Throwing Speed (0.5% per 1% Q)" },
            { "Tectonic Slam" , " 10% increased Area of Effect (0.5% per 1% Q)" },
            { "Tempest Shield" , " 20% increased Lightning Damage (1% per 1% Q)" },
            { "Temporal Chains" , " Cursed Normal and Magic Enemies have 10% less Action Speed (0.5% per 1% Q)" },
            { "Tornado Shot" , " 20% increased Projectile Damage (1% per 1% Q)" },
            { "Toxic Rain" , " 10% increased Area of Effect (0.5% per 1% Q)" },
            { "Trap and Mine Damage Support" , " 10% increased Damage (0.5% per 1% Q)" },
            { "Trap Support" , " 10% increased Trap Throwing Speed (0.5% per 1% Q)" },
            { "Unbound Ailments Support" , " 10% increased Duration of Ailments on Enemies (0.5% per 1% Q)" },
            { "Unearth" , " 10% increased Cast Speed (0.5% per 1% Q)" },
            { "Unleash Support" , " 10% increased Spell Damage (0.5% per 1% Q)" },
            { "Vaal Ancestral Warchief" , " 20% increased Totem Damage (1% per 1% Q)" },
            { "Vaal Arc" , " 30% increased Shock Duration on enemies (1.5% per 1% Q)" },
            { "Vaal Blade Vortex" , " 10% increased Area of Effect (0.5% per 1% Q)" },
            { "Vaal Blight" , " 10% increased Area of Effect (0.5% per 1% Q)" },
            { "Vaal Breach" , " 60% increased Cast Speed (3% per 1% Q)" },
            { "Vaal Burning Arrow" , " 60% increased Ignite Duration on enemies (3% per 1% Q)" },
            { "Vaal Clarity" , " 40% increased Area of Effect (2% per 1% Q)" },
            { "Vaal Cold Snap" , " 10% increased Area of Effect (0.5% per 1% Q)" },
            { "Vaal Cyclone" , " 10% increased Area of Effect (0.5% per 1% Q)" },
            { "Vaal Detonate Dead" , " 20% increased Area Damage (1% per 1% Q)" },
            { "Vaal Discipline" , " 40% increased Area of Effect (2% per 1% Q)" },
            { "Vaal Double Strike" , " 10% increased Attack Speed (0.5% per 1% Q)" },
            { "Vaal Earthquake" , " 20% increased Damage (1% per 1% Q)" },
            { "Vaal Fireball" , " 10% chance to Ignite enemies (0.5% per 1% Q)" },
            { "Vaal Flameblast" , " 20% increased Damage (1% per 1% Q)" },
            { "Vaal Glacial Hammer" , " 40% increased Chill Duration on enemies 20% increased Freeze Duration on enemies (2% / 1% per 1% Q)" },
            { "Vaal Grace" , " 40% increased Area of Effect (2% per 1% Q)" },
            { "Vaal Ground Slam" , " 20% increased Stun Duration on enemies 10% increased Area of Effect (1% / 0.5% per 1% Q)" },
            { "Vaal Haste" , " 40% increased Area of Effect (2% per 1% Q)" },
            { "Vaal Ice Nova" , " 10% increased Area of Effect (0.5% per 1% Q)" },
            { "Vaal Immortal Call" , " 20% increased Skill Effect Duration (1% per 1% Q)" },
            { "Vaal Impurity of Fire" , " 40% increased Area of Effect (2% per 1% Q)" },
            { "Vaal Impurity of Ice" , " 40% increased Area of Effect (2% per 1% Q)" },
            { "Vaal Impurity of Lightning" , " 40% increased Area of Effect (2% per 1% Q)" },
            { "Vaal Lightning Strike" , " 20% increased Damage 20% increased Projectile Speed (1% per 1% Q)" },
            { "Vaal Lightning Trap" , " Shocked Ground causes 5% increased Damage taken (0.25% per 1% Q)" },
            { "Vaal Lightning Warp" , " 20% increased Cast Speed (1% per 1% Q)" },
            { "Vaal Molten Shell" , " 20% increased Skill Effect Duration (1% per 1% Q)" },
            { "Vaal Power Siphon" , " 20% increased Damage (1% per 1% Q)" },
            { "Vaal Rain of Arrows" , " 10% increased Area of Effect (0.5% per 1% Q)" },
            { "Vaal Reave" , " 10% increased Attack Speed (0.5% per 1% Q)" },
            { "Vaal Righteous Fire" , " 20% increased Burning Damage (1% per 1% Q)" },
            { "Vaal Spark" , " 20% increased Projectile Speed (1% per 1% Q)" },
            { "Vaal Spectral Throw" , " 10% increased Attack Speed (0.5% per 1% Q)" },
            { "Vaal Storm Call" , " 10% increased Area of Effect (0.5% per 1% Q)" },
            { "Vaal Summon Skeletons" , " Minions deal 20% increased Damage (1% per 1% Q)" },
            { "Vengeance" , " 10% chance to Trigger this Skill when Hit (0.5% per 1% Q)" },
            { "Venom Gyre" , " 20% increased Poison Duration (1% per 1% Q)" },
            { "Vicious Projectiles Support" , " 10% increased Physical Damage (0.5% per 1% Q)" },
            { "Vigilant Strike" , " 40% increased Fortify duration (2% per 1% Q)" },
            { "Vile Toxins Support" , " 20% increased Damage with Poison (1% per 1% Q)" },
            { "Viper Strike" , " 10% increased Attack Speed 10% increased Poison Duration (0.5% per 1% Q)" },
            { "Vitality" , " 40% increased Area of Effect (2% per 1% Q)" },
            { "Void Manipulation Support" , " 10% increased Chaos Damage (0.5% per 1% Q)" },
            { "Volatile Dead" , " 10% increased Area of Effect (0.5% per 1% Q)" },
            { "Volley Support" , " 20% increased Projectile Damage (1% per 1% Q)" },
            { "Vortex" , " 10% increased Area of Effect (0.5% per 1% Q)" },
            { "Vulnerability" , " Cursed Enemies have 10% chance to Bleed when Hit by Attacks (0.5% per 1% Q)" },
            { "War Banner" , " 10% increased effect of Aura (0.5% per 1% Q)" },
            { "Warlord's Mark" , " Cursed enemies have a 10% chance to grant an Endurance Charge when slain (0.5% per 1% Q)" },
            { "Wave of Conviction" , " 20% increased Elemental Damage (1% per 1% Q)" },
            { "Whirling Blades" , " 10% increased Attack Speed (0.5% per 1% Q)" },
            { "Wild Strike" , " 20% increased Elemental Damage (1% per 1% Q)" },
            { "Winter Orb" , " 10% increased Cast Speed (0.5% per 1% Q)" },
            { "Wither" , " 20% increased Skill Effect Duration (1% per 1% Q)" },
            { "Withering Step" , " 10% increased Effect of Elusive from this Skill (0.5% per 1% Q)" },
            { "Withering Touch Support" , " 10% increased Chaos Damage (0.5% per 1% Q)" },
            { "Wrath" , " 40% increased Area of Effect (2% per 1% Q)" },
            { "Zealotry" , " 40% increased Area of Effect (2% per 1% Q)" },
            { "Barrage Support", "Supported Skills have 0.5% increased Attack Speed" },
            { "Awakened Added Chaos Damage Support", "Supported Skills deal 0.5% increased Chaos Damage" }, { "Awakened Added Cold Damage Support", "Supported Skills deal 0.5% increased Cold Damage" }, { "Awakened Added Fire Damage Support", "Supported Skills deal 1% increased Fire Damage" }, { "Awakened Added Lightning Damage Support", "Supported Skills deal 0.5% increased Lightning Damage" },
            { "Awakened Ancestral Call Support", "Supported Skills have 0.5% increased Attack Speed Extra Targets for Supported Skills can be found 1% further away" },
            { "Awakened Arrow Nova Support", "Supported Skills have 1% increased Attack Speed" }, { "Awakened Blasphemy Support", "0.5% increased Effect of Supported Curses +0.05 to Level of Supported Curse Skill Gems" }, { "Awakened Brutality Support", "Supported Skills deal 0.5% increased Physical Damage Enemies have -0.5% to Total Physical Damage Reduction against your Hits" }, { "Awakened Cold Penetration Support", "Supported Skills deal 1% increased Cold Damage" },
            { "Awakened Burning Damage Support", "Supported Skills deal 0.5% increased Burning Damage, +0.5% to Fire Damage over Time Multiplier" }, { "Awakened Cast On Critical Strike Support", "" }, { "Awakened Cast While Channelling Support", "" }, { "Awakened Chain Support", "" },
            { "Awakened Controlled Destruction Support", "Supported Skills deal 0.5% increased Spell Damage, Supported Skills have 0.5% increased Cast Speed" }, { "Awakened Curse On Hit Support", "0.5% increased Effect of Supported Curses, Supported Curse Skills have 0.5% chance to apply to Hexproof Enemies" }, { "Awakened Deadly Ailments Support", "Supported Skills deal 0.5% increased Damage over Time" }, { "Awakened Elemental Damage With Attacks Support", "1% increased Elemental Damage with Attack Skills" },
            { "Awakened Elemental Focus Support", "Supported Skills deal 1% increased Elemental Damage" }, { "Awakened Fire Penetration Support", "Supported Skills deal 1% increased Fire Damage" }, { "Awakened Fork Support", "Supported Skills deal 1% increased Projectile Damage" }, { "Awakened Generosity Support", "Supported Skills have 2% increased Aura Area of Effect, +0.05 to Level of Supported Aura Skill Gems" },
            { "Awakened Greater Multiple Projectiles Support", "Supported Skills have 1% increased Attack Speed, Supported Skills have 1% increased Cast Speed" }, { "Awakened Increased Area Of Effect Support", "Supported Skills deal 0.5% increased Area Damage" }, { "Awakened Lightning Penetration Support", "Supported Skills deal 1% increased Lightning Damage" }, { "Awakened Melee Physical Damage Support", "Supported Skills deal 0.5% increased Melee Physical Damage, 0.5% chance to Intimidate Enemies for 4 seconds on Hit" },
            { "Awakened Melee Splash Support", "Supported Skills have 1% increased Area of Effect" }, { "Awakened Minion Damage Support", "Minions from Supported Skills deal 1% increased Damage" }, { "Awakened Multistrike Support", "Supported Skills deal 0.5% increased Melee Physical Damage, Supported Skills have 0.5% increased Attack Speed" }, { "Awakened Spell Cascade Support", "Supported Skills have 0.5% increased Area of Effect, Supported Skills deal 0.5% increased Spell Damage" },
            { "Awakened Spell Echo Support", "Supported Skills deal 0.5% increased Spell Damage, Supported Skills have 0.5% increased Cast Speed" }, { "Awakened Swift Affliction Support", "Supported Skills deal 0.5% increased Damage over Time, +0.5% to Damage over Time Multiplier" }, { "Awakened Unbound Ailments Support", "Supported Skills have 0.5% increased Duration of Ailments on Enemies, +0.5% to Damage over Time Multiplier" }, { "Awakened Unleash Support", "Supported Skills deal 1% increased Spell Damage" },
            { "Awakened Vicious Projectiles Support", "Supported Skills deal 1% increased Physical Damage" }, { "Awakened Void Manipulation Support", "Supported Skills deal 1% increased Chaos Damage" }
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