using FirstRPG.Entities.Items;
using FirstRPG.Entities.Items.Materials;


namespace FirstRPG.Entities.Items
{
    public class ItemDatabase
    {
        private List<Item> items = new List<Item>();
        
       
        

        public List<Item> GetAllItems()
        {
            return items;
        
        }

 public Item CreateItem(ItemsId id)
{
    switch (id)
    {
        case ItemsId.Wooden_Sword:
            return new Weapon(
                (int)id,
                "Wooden Sword",
                "Ağaçtan yapılma basit bir kılıç",
                10,
                ItemRarity.Common,
                EquipmentsType.Sword,
                5,
                20,
                20,
                1,
                1,
                BaseMaterial.Wood);

        case ItemsId.Iron_Sword:
            return new Weapon(
                (int)id,
                "Iron Sword",
                "Demir kılıç",
                50,
                ItemRarity.Uncommon,
                EquipmentsType.Sword,
                9,
                40,
                40,
                5,
                1,
                BaseMaterial.Iron);

        case ItemsId.Steel_Sword:
            return new Weapon(
                (int)id,
                "Steel Sword",
                "Çelik kılıç",
                120,
                ItemRarity.Rare,
                EquipmentsType.Sword,
                16,
                80,
                80,
                12,
                1,
                BaseMaterial.Steel);

        case ItemsId.Cloth_Hood:
            return new Armor(
                (int)id,
                "Cloth Hood",
                "Basit kumaş başlık",
                10,
                ItemRarity.Common,
                EquipmentsType.HeadArmor,
                1,
                20,
                20,
                1,
                1,
                BaseMaterial.Cloth);

        case ItemsId.Iron_Armor:
            return new Armor(
                (int)id,
                "Iron Armor",
                "Demir göğüs zırhı",
                120,
                ItemRarity.Rare,
                EquipmentsType.ChestArmor,
                10,
                90,
                90,
                12,
                1,
                BaseMaterial.Iron);

        case ItemsId.Stone:
            return new Material(
                (int)id,
                "Stone",
                "Basit Taş",
                1,
                999,
                ItemRarity.Common,
                true,
                BaseMaterial.Stone
            );

        case ItemsId.Stick:
            return new Material(
                (int)id,
                "Stick",
                "Odun dalı",
                1,
                999,
                ItemRarity.Common,
                true,
                BaseMaterial.Wood);

        case ItemsId.IronOre:
            return new Material(
                (int)id,
                "Iron Ore",
                "Demir cevheri",
                5,
                999,
                ItemRarity.Common,
                true,
                BaseMaterial.Iron);

        case ItemsId.DragonScale:
            return new Material(
                (int)id,
                "Dragon Scale",
                "Ejderha pulları",
                500,
                10,
                ItemRarity.Legendary,
                true,
                BaseMaterial.Scale);

        default:
            throw new Exception("Item bulunamadı");
            
    }
}

    


    }



public enum BaseMaterial
{
    none,

    // Natural / Basic
    Wood,
    Stone,
    Flint,
    Bone,
    Leather,
    Cloth,

    // Metals
    Copper,
    Tin,
    Bronze,
    Iron,
    Steel,
    Silver,
    Gold,
    Mithril,
    Adamantite,

    // Minerals / Crystals
    Coal,
    Obsidian,
    Crystal,
    Diamond,

    // Organic / Monster
    Hide,
    Fang,
    Claw,
    Scale,
    Feather,

    // Magical / Elemental
    Fire,
    Water,
    Ice,
    Lightning,
    Shadow,
    Light,
    Arcane,

    // Special
    Spirit,
    Ancient
}
    



public enum ItemsId
{
    // Materials 1000
    Stone = 1001,
    Stick = 1002,
    Wood = 1003,
    IronOre = 1004,
    CopperOre = 1005,
    Coal = 1006,
    Leather = 1007,
    Cloth = 1008,
    Bone = 1009,
    Feather = 1010,
    Crystal = 1011,
    MagicDust = 1012,
    DragonScale = 1013,
    SilverOre = 1014,
    GoldOre = 1015,
    Obsidian = 1016,
    RuneStone = 1017,
    AncientRelic = 1018,
    SpiderSilk = 1019,
    BeastFang = 1020,

    // Weapons 2000
    Wooden_Sword = 2001,
    Rusty_Dagger = 2002,
    Old_Spear = 2003,
    Training_Staff = 2004,
    Farmer_Axe = 2005,
    Cracked_Mace = 2006,
    Hunting_Bow = 2007,
    Wooden_Club = 2008,

    Iron_Sword = 2009,
    Iron_Dagger = 2010,
    Iron_Spear = 2011,
    Iron_Axe = 2012,
    Iron_Mace = 2013,
    Long_Bow = 2014,
    Apprentice_Staff = 2015,
    Short_Warhammer = 2016,

    Steel_Sword = 2017,
    Steel_Dagger = 2018,
    Steel_Spear = 2019,
    Steel_Axe = 2020,
    Steel_Mace = 2021,
    War_Bow = 2022,
    Adept_Staff = 2023,
    Knight_GreatSword = 2024,

    Dragon_Slayer = 2025,
    Assassin_Dagger = 2026,
    Knight_Halberd = 2027,
    War_Axe = 2028,
    Skull_Crusher = 2029,
    Elven_Bow = 2030,
    Arcane_Staff = 2031,
    Blood_Mace = 2032,

    Phoenix_Blade = 2033,
    Shadow_Dagger = 2034,
    Storm_Spear = 2035,
    Titan_Axe = 2036,
    Thunder_Hammer = 2037,
    Celestial_Bow = 2038,
    Archmage_Staff = 2039,
    Sunblade = 2040,

    Void_Reaver = 2041,
    Godslayer_Dagger = 2042,
    Leviathan_Spear = 2043,
    World_Breaker = 2044,
    Doom_Hammer = 2045,
    Astral_Bow = 2046,
    Cosmic_Staff = 2047,
    Eclipse_Blade = 2048,
    Infinity_Dagger = 2049,
    Chaos_Spear = 2050,

    // Armor 3000
    Cloth_Hood = 3001,
    Cloth_Robe = 3002,
    Cloth_Gloves = 3003,
    Cloth_Pants = 3004,
    Cloth_Boots = 3005,

    Leather_Cap = 3006,
    Leather_Armor = 3007,
    Leather_Gloves = 3008,
    Leather_Leggings = 3009,
    Leather_Boots = 3010,

    Iron_Helmet = 3011,
    Iron_Armor = 3012,
    Iron_Gloves = 3013,
    Iron_Leggings = 3014,
    Iron_Boots = 3015,

    Steel_Helmet = 3016,
    Steel_Armor = 3017,
    Steel_Gloves = 3018,
    Steel_Leggings = 3019,
    Steel_Boots = 3020,

    Knight_Helm = 3021,
    Knight_Armor = 3022,
    Knight_Gauntlets = 3023,
    Knight_Leggings = 3024,
    Knight_Boots = 3025,

    Dragon_Helm = 3026,
    Dragon_Armor = 3027,
    Dragon_Gauntlets = 3028,
    Dragon_Leggings = 3029,
    Dragon_Boots = 3030,

    Celestial_Helm = 3031,
    Celestial_Armor = 3032,
    Celestial_Gloves = 3033,
    Celestial_Leggings = 3034,
    Celestial_Boots = 3035,

    Wooden_Shield = 3036,
    Iron_Shield = 3037,
    Steel_Shield = 3038,
    Knight_Shield = 3039,
    Dragon_Shield = 3040
}

     public enum ItemType
    {
        Potion,
        Weapon,
        Armor,
        Material
    }

    public enum ItemRarity
{
    Common,
    Uncommon,
    Rare,
    Epic,
    Legendary,
    Mythic
}
    public enum EquipmentsType
    {
        //Armor
        HeadArmor,
        ChestArmor,
        HandArmor,
        LegArmor,
        FeetArmor,
        Shield,



        //Weapon 
        Sword,
        Axe,
        Bow,
        Staff,
        Dagger,
        Spear,
        Shovel


    }




 
}