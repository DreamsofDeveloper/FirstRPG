using FirstRPG.Entities.Items;

public class CraftSystem
{
    private readonly ItemDatabase itemdatabase;
    private readonly List<Recipe> recipes = new();
    

    public CraftSystem()
    {
        itemdatabase = new ItemDatabase();

// ─────────────────────────────────────────────
// SMELTING — Ore → Ingot
// ─────────────────────────────────────────────

recipes.Add(new Recipe(ItemsId.IronIngot, new List<(ItemsId, int)>
{
    (ItemsId.IronOre, 2),
    (ItemsId.Coal,    1)
}));

recipes.Add(new Recipe(ItemsId.GoldIngot, new List<(ItemsId, int)>
{
    (ItemsId.GoldOre, 2),
    (ItemsId.Coal,    2)
}));

recipes.Add(new Recipe(ItemsId.CopperIngot, new List<(ItemsId, int)>
{
    (ItemsId.CopperOre, 2),
    (ItemsId.Coal,      1)
}));


// ─────────────────────────────────────────────
// WEAPONS — Tier 1 · Common  (Wood/Stone)
// ─────────────────────────────────────────────

recipes.Add(new Recipe(ItemsId.Wooden_Sword, new List<(ItemsId, int)>
{
    (ItemsId.Stick, 1),
    (ItemsId.Wood,  2)
}));

recipes.Add(new Recipe(ItemsId.Wooden_Club, new List<(ItemsId, int)>
{
    (ItemsId.Wood, 3)
}));

recipes.Add(new Recipe(ItemsId.Training_Staff, new List<(ItemsId, int)>
{
    (ItemsId.Stick, 2),
    (ItemsId.Wood,  1)
}));

recipes.Add(new Recipe(ItemsId.Hunting_Bow, new List<(ItemsId, int)>
{
    (ItemsId.Wood,  2),
    (ItemsId.Stick, 1)
}));


// ─────────────────────────────────────────────
// WEAPONS — Tier 2 · Uncommon  (Iron)
// ─────────────────────────────────────────────

recipes.Add(new Recipe(ItemsId.Iron_Sword, new List<(ItemsId, int)>
{
    (ItemsId.IronIngot, 3),
    (ItemsId.Stick,     1)
}));

recipes.Add(new Recipe(ItemsId.Iron_Dagger, new List<(ItemsId, int)>
{
    (ItemsId.IronIngot, 2),
    (ItemsId.Stick,     1)
}));

recipes.Add(new Recipe(ItemsId.Iron_Spear, new List<(ItemsId, int)>
{
    (ItemsId.IronIngot, 2),
    (ItemsId.Wood,      2)
}));

recipes.Add(new Recipe(ItemsId.Iron_Axe, new List<(ItemsId, int)>
{
    (ItemsId.IronIngot, 3),
    (ItemsId.Wood,      1)
}));

recipes.Add(new Recipe(ItemsId.Iron_Mace, new List<(ItemsId, int)>
{
    (ItemsId.IronIngot, 4),
    (ItemsId.Stick,     1)
}));

recipes.Add(new Recipe(ItemsId.Long_Bow, new List<(ItemsId, int)>
{
    (ItemsId.Wood,    3),
    (ItemsId.Leather, 2)
}));

recipes.Add(new Recipe(ItemsId.Apprentice_Staff, new List<(ItemsId, int)>
{
    (ItemsId.Wood,    2),
    (ItemsId.Crystal, 1)
}));

recipes.Add(new Recipe(ItemsId.Short_Warhammer, new List<(ItemsId, int)>
{
    (ItemsId.IronIngot, 4),
    (ItemsId.Wood,      1)
}));


// ─────────────────────────────────────────────
// WEAPONS — Tier 3 · Rare  (Steel)
// Steel = fazla IronIngot + Coal ile dövme
// ─────────────────────────────────────────────

recipes.Add(new Recipe(ItemsId.Steel_Sword, new List<(ItemsId, int)>
{
    (ItemsId.IronIngot, 5),
    (ItemsId.Coal,      3),
    (ItemsId.Leather,   1)
}));

recipes.Add(new Recipe(ItemsId.Steel_Dagger, new List<(ItemsId, int)>
{
    (ItemsId.IronIngot, 3),
    (ItemsId.Coal,      2),
    (ItemsId.Leather,   1)
}));

recipes.Add(new Recipe(ItemsId.Steel_Spear, new List<(ItemsId, int)>
{
    (ItemsId.IronIngot, 4),
    (ItemsId.Coal,      2),
    (ItemsId.Wood,      2)
}));

recipes.Add(new Recipe(ItemsId.Steel_Axe, new List<(ItemsId, int)>
{
    (ItemsId.IronIngot, 5),
    (ItemsId.Coal,      3),
    (ItemsId.Wood,      1)
}));

recipes.Add(new Recipe(ItemsId.Steel_Mace, new List<(ItemsId, int)>
{
    (ItemsId.IronIngot, 6),
    (ItemsId.Coal,      3),
    (ItemsId.Leather,   1)
}));

recipes.Add(new Recipe(ItemsId.War_Bow, new List<(ItemsId, int)>
{
    (ItemsId.Wood,      4),
    (ItemsId.Leather,   3),
    (ItemsId.IronIngot, 1)   // metal uç
}));

recipes.Add(new Recipe(ItemsId.Adept_Staff, new List<(ItemsId, int)>
{
    (ItemsId.Wood,      3),
    (ItemsId.Crystal,   2),
    (ItemsId.MagicDust, 1)
}));

recipes.Add(new Recipe(ItemsId.Knight_GreatSword, new List<(ItemsId, int)>
{
    (ItemsId.IronIngot, 6),
    (ItemsId.Coal,      4),
    (ItemsId.Leather,   2)
}));


// ─────────────────────────────────────────────
// WEAPONS — Tier 4 · Epic
// Epic = yüksek IronIngot + nadir organik bileşenler
// ─────────────────────────────────────────────

recipes.Add(new Recipe(ItemsId.Dragon_Slayer, new List<(ItemsId, int)>
{
    (ItemsId.IronIngot,  8),
    (ItemsId.Coal,       4),
    (ItemsId.DragonScale,2),
    (ItemsId.BeastFang,  1)
}));

recipes.Add(new Recipe(ItemsId.Assassin_Dagger, new List<(ItemsId, int)>
{
    (ItemsId.IronIngot,  5),
    (ItemsId.SpiderSilk, 2),
    (ItemsId.Obsidian,   1)
}));

recipes.Add(new Recipe(ItemsId.Knight_Halberd, new List<(ItemsId, int)>
{
    (ItemsId.IronIngot, 8),
    (ItemsId.Coal,      4),
    (ItemsId.Wood,      2),
    (ItemsId.Leather,   2)
}));

recipes.Add(new Recipe(ItemsId.War_Axe, new List<(ItemsId, int)>
{
    (ItemsId.IronIngot, 8),
    (ItemsId.Coal,      4),
    (ItemsId.BeastFang, 1)
}));

recipes.Add(new Recipe(ItemsId.Skull_Crusher, new List<(ItemsId, int)>
{
    (ItemsId.IronIngot, 8),
    (ItemsId.Bone,      4),
    (ItemsId.Obsidian,  1)
}));

recipes.Add(new Recipe(ItemsId.Elven_Bow, new List<(ItemsId, int)>
{
    (ItemsId.Wood,      5),
    (ItemsId.SpiderSilk,3),
    (ItemsId.Crystal,   2),
    (ItemsId.Feather,   4)
}));

recipes.Add(new Recipe(ItemsId.Arcane_Staff, new List<(ItemsId, int)>
{
    (ItemsId.Wood,      3),
    (ItemsId.Crystal,   3),
    (ItemsId.MagicDust, 3),
    (ItemsId.RuneStone, 1)
}));

recipes.Add(new Recipe(ItemsId.Blood_Mace, new List<(ItemsId, int)>
{
    (ItemsId.IronIngot, 8),
    (ItemsId.BeastFang, 2),
    (ItemsId.Bone,      3)
}));


// ─────────────────────────────────────────────
// WEAPONS — Tier 5 · Legendary
// Legendary = GoldIngot/SilverOre + DragonScale + RuneStone/AncientRelic
// ─────────────────────────────────────────────

recipes.Add(new Recipe(ItemsId.Phoenix_Blade, new List<(ItemsId, int)>
{
    (ItemsId.GoldIngot,   4),
    (ItemsId.DragonScale, 3),
    (ItemsId.RuneStone,   2),
    (ItemsId.MagicDust,   5)
}));

recipes.Add(new Recipe(ItemsId.Shadow_Dagger, new List<(ItemsId, int)>
{
    (ItemsId.Obsidian,    4),
    (ItemsId.SpiderSilk,  4),
    (ItemsId.AncientRelic,1),
    (ItemsId.MagicDust,   4)
}));

recipes.Add(new Recipe(ItemsId.Storm_Spear, new List<(ItemsId, int)>
{
    (ItemsId.GoldIngot,  3),
    (ItemsId.Crystal,    4),
    (ItemsId.RuneStone,  2),
    (ItemsId.MagicDust,  4)
}));

recipes.Add(new Recipe(ItemsId.Titan_Axe, new List<(ItemsId, int)>
{
    (ItemsId.GoldIngot,   5),
    (ItemsId.DragonScale, 2),
    (ItemsId.AncientRelic,1),
    (ItemsId.IronIngot,   4)
}));

recipes.Add(new Recipe(ItemsId.Thunder_Hammer, new List<(ItemsId, int)>
{
    (ItemsId.GoldIngot, 5),
    (ItemsId.Crystal,   4),
    (ItemsId.RuneStone, 3),
    (ItemsId.MagicDust, 5)
}));

recipes.Add(new Recipe(ItemsId.Celestial_Bow, new List<(ItemsId, int)>
{
    (ItemsId.SilverOre,  4),
    (ItemsId.SpiderSilk, 5),
    (ItemsId.Crystal,    4),
    (ItemsId.Feather,    6)
}));

recipes.Add(new Recipe(ItemsId.Archmage_Staff, new List<(ItemsId, int)>
{
    (ItemsId.SilverOre,   3),
    (ItemsId.Crystal,     5),
    (ItemsId.MagicDust,   6),
    (ItemsId.AncientRelic,1)
}));

recipes.Add(new Recipe(ItemsId.Sunblade, new List<(ItemsId, int)>
{
    (ItemsId.GoldIngot,   5),
    (ItemsId.DragonScale, 3),
    (ItemsId.MagicDust,   5),
    (ItemsId.RuneStone,   2)
}));


// ─────────────────────────────────────────────
// WEAPONS — Tier 6 · Mythic
// Mythic = DragonScale + AncientRelic kombonu zorunlu
// ─────────────────────────────────────────────

recipes.Add(new Recipe(ItemsId.Void_Reaver, new List<(ItemsId, int)>
{
    (ItemsId.Obsidian,    6),
    (ItemsId.DragonScale, 5),
    (ItemsId.AncientRelic,3),
    (ItemsId.MagicDust,   8)
}));

recipes.Add(new Recipe(ItemsId.Godslayer_Dagger, new List<(ItemsId, int)>
{
    (ItemsId.Obsidian,    5),
    (ItemsId.DragonScale, 4),
    (ItemsId.AncientRelic,3),
    (ItemsId.SpiderSilk,  5)
}));

recipes.Add(new Recipe(ItemsId.Leviathan_Spear, new List<(ItemsId, int)>
{
    (ItemsId.GoldIngot,   6),
    (ItemsId.DragonScale, 5),
    (ItemsId.AncientRelic,3),
    (ItemsId.RuneStone,   4)
}));

recipes.Add(new Recipe(ItemsId.World_Breaker, new List<(ItemsId, int)>
{
    (ItemsId.GoldIngot,   8),
    (ItemsId.DragonScale, 6),
    (ItemsId.AncientRelic,4),
    (ItemsId.IronIngot,   6)
}));

recipes.Add(new Recipe(ItemsId.Doom_Hammer, new List<(ItemsId, int)>
{
    (ItemsId.GoldIngot,   8),
    (ItemsId.DragonScale, 6),
    (ItemsId.AncientRelic,4),
    (ItemsId.Obsidian,    5)
}));

recipes.Add(new Recipe(ItemsId.Astral_Bow, new List<(ItemsId, int)>
{
    (ItemsId.SilverOre,   6),
    (ItemsId.DragonScale, 4),
    (ItemsId.AncientRelic,3),
    (ItemsId.Feather,     8)
}));

recipes.Add(new Recipe(ItemsId.Cosmic_Staff, new List<(ItemsId, int)>
{
    (ItemsId.Crystal,     8),
    (ItemsId.DragonScale, 4),
    (ItemsId.AncientRelic,4),
    (ItemsId.MagicDust,  10)
}));

recipes.Add(new Recipe(ItemsId.Eclipse_Blade, new List<(ItemsId, int)>
{
    (ItemsId.Obsidian,    6),
    (ItemsId.GoldIngot,   6),
    (ItemsId.AncientRelic,4),
    (ItemsId.DragonScale, 5)
}));

recipes.Add(new Recipe(ItemsId.Infinity_Dagger, new List<(ItemsId, int)>
{
    (ItemsId.Obsidian,    5),
    (ItemsId.SilverOre,   5),
    (ItemsId.AncientRelic,4),
    (ItemsId.MagicDust,   8)
}));

recipes.Add(new Recipe(ItemsId.Chaos_Spear, new List<(ItemsId, int)>
{
    (ItemsId.GoldIngot,   7),
    (ItemsId.DragonScale, 6),
    (ItemsId.AncientRelic,4),
    (ItemsId.RuneStone,   5)
}));


// ─────────────────────────────────────────────
// ARMOR — Tier 1 · Common  (Cloth)
// ─────────────────────────────────────────────

recipes.Add(new Recipe(ItemsId.Wooden_Shield, new List<(ItemsId, int)>
{
    (ItemsId.Wood,  4),
    (ItemsId.Stick, 2)
}));

recipes.Add(new Recipe(ItemsId.Cloth_Hood, new List<(ItemsId, int)>
{
    (ItemsId.Cloth, 2)
}));

recipes.Add(new Recipe(ItemsId.Cloth_Robe, new List<(ItemsId, int)>
{
    (ItemsId.Cloth, 4)
}));

recipes.Add(new Recipe(ItemsId.Cloth_Gloves, new List<(ItemsId, int)>
{
    (ItemsId.Cloth, 2)
}));

recipes.Add(new Recipe(ItemsId.Cloth_Pants, new List<(ItemsId, int)>
{
    (ItemsId.Cloth, 3)
}));

recipes.Add(new Recipe(ItemsId.Cloth_Boots, new List<(ItemsId, int)>
{
    (ItemsId.Cloth, 2)
}));


// ─────────────────────────────────────────────
// ARMOR — Tier 2 · Uncommon  (Leather)
// ─────────────────────────────────────────────

recipes.Add(new Recipe(ItemsId.Leather_Cap, new List<(ItemsId, int)>
{
    (ItemsId.Leather, 2),
    (ItemsId.Cloth,   1)
}));

recipes.Add(new Recipe(ItemsId.Leather_Armor, new List<(ItemsId, int)>
{
    (ItemsId.Leather, 5),
    (ItemsId.Cloth,   2)
}));

recipes.Add(new Recipe(ItemsId.Leather_Gloves, new List<(ItemsId, int)>
{
    (ItemsId.Leather, 2),
    (ItemsId.Cloth,   1)
}));

recipes.Add(new Recipe(ItemsId.Leather_Leggings, new List<(ItemsId, int)>
{
    (ItemsId.Leather, 4),
    (ItemsId.Cloth,   1)
}));

recipes.Add(new Recipe(ItemsId.Leather_Boots, new List<(ItemsId, int)>
{
    (ItemsId.Leather, 3),
    (ItemsId.Cloth,   1)
}));


// ─────────────────────────────────────────────
// ARMOR — Tier 3 · Rare  (Iron)
// ─────────────────────────────────────────────

recipes.Add(new Recipe(ItemsId.Iron_Helmet, new List<(ItemsId, int)>
{
    (ItemsId.IronIngot, 3),
    (ItemsId.Leather,   1)
}));

recipes.Add(new Recipe(ItemsId.Iron_Armor, new List<(ItemsId, int)>
{
    (ItemsId.IronIngot, 6),
    (ItemsId.Leather,   2)
}));

recipes.Add(new Recipe(ItemsId.Iron_Gloves, new List<(ItemsId, int)>
{
    (ItemsId.IronIngot, 2),
    (ItemsId.Leather,   1)
}));

recipes.Add(new Recipe(ItemsId.Iron_Leggings, new List<(ItemsId, int)>
{
    (ItemsId.IronIngot, 4),
    (ItemsId.Leather,   1)
}));

recipes.Add(new Recipe(ItemsId.Iron_Boots, new List<(ItemsId, int)>
{
    (ItemsId.IronIngot, 3),
    (ItemsId.Leather,   1)
}));

recipes.Add(new Recipe(ItemsId.Iron_Shield, new List<(ItemsId, int)>
{
    (ItemsId.IronIngot, 5),
    (ItemsId.Wood,      1)
}));


// ─────────────────────────────────────────────
// ARMOR — Tier 4 · Rare  (Steel)
// Fazla IronIngot + Coal = çelik kalite
// ─────────────────────────────────────────────

recipes.Add(new Recipe(ItemsId.Steel_Helmet, new List<(ItemsId, int)>
{
    (ItemsId.IronIngot, 4),
    (ItemsId.Coal,      3),
    (ItemsId.Leather,   1)
}));

recipes.Add(new Recipe(ItemsId.Steel_Armor, new List<(ItemsId, int)>
{
    (ItemsId.IronIngot, 8),
    (ItemsId.Coal,      5),
    (ItemsId.Leather,   2)
}));

recipes.Add(new Recipe(ItemsId.Steel_Gloves, new List<(ItemsId, int)>
{
    (ItemsId.IronIngot, 3),
    (ItemsId.Coal,      2),
    (ItemsId.Leather,   1)
}));

recipes.Add(new Recipe(ItemsId.Steel_Leggings, new List<(ItemsId, int)>
{
    (ItemsId.IronIngot, 6),
    (ItemsId.Coal,      4),
    (ItemsId.Leather,   1)
}));

recipes.Add(new Recipe(ItemsId.Steel_Boots, new List<(ItemsId, int)>
{
    (ItemsId.IronIngot, 4),
    (ItemsId.Coal,      3),
    (ItemsId.Leather,   1)
}));

recipes.Add(new Recipe(ItemsId.Steel_Shield, new List<(ItemsId, int)>
{
    (ItemsId.IronIngot, 7),
    (ItemsId.Coal,      4),
    (ItemsId.Wood,      1)
}));


// ─────────────────────────────────────────────
// ARMOR — Tier 5 · Epic  (Knight)
// ─────────────────────────────────────────────

recipes.Add(new Recipe(ItemsId.Knight_Helm, new List<(ItemsId, int)>
{
    (ItemsId.IronIngot, 6),
    (ItemsId.Coal,      4),
    (ItemsId.BeastFang, 1),
    (ItemsId.Leather,   2)
}));

recipes.Add(new Recipe(ItemsId.Knight_Armor, new List<(ItemsId, int)>
{
    (ItemsId.IronIngot, 12),
    (ItemsId.Coal,       6),
    (ItemsId.BeastFang,  2),
    (ItemsId.Leather,    4)
}));

recipes.Add(new Recipe(ItemsId.Knight_Gauntlets, new List<(ItemsId, int)>
{
    (ItemsId.IronIngot, 5),
    (ItemsId.Coal,      3),
    (ItemsId.Leather,   2)
}));

recipes.Add(new Recipe(ItemsId.Knight_Leggings, new List<(ItemsId, int)>
{
    (ItemsId.IronIngot, 8),
    (ItemsId.Coal,      5),
    (ItemsId.BeastFang, 1),
    (ItemsId.Leather,   3)
}));

recipes.Add(new Recipe(ItemsId.Knight_Boots, new List<(ItemsId, int)>
{
    (ItemsId.IronIngot, 6),
    (ItemsId.Coal,      4),
    (ItemsId.Leather,   2)
}));

recipes.Add(new Recipe(ItemsId.Knight_Shield, new List<(ItemsId, int)>
{
    (ItemsId.IronIngot, 10),
    (ItemsId.Coal,       5),
    (ItemsId.Wood,       2),
    (ItemsId.BeastFang,  1)
}));


// ─────────────────────────────────────────────
// ARMOR — Tier 6 · Legendary  (Dragon)
// GoldIngot + DragonScale
// ─────────────────────────────────────────────

recipes.Add(new Recipe(ItemsId.Dragon_Helm, new List<(ItemsId, int)>
{
    (ItemsId.DragonScale, 3),
    (ItemsId.GoldIngot,   2),
    (ItemsId.RuneStone,   1),
    (ItemsId.Leather,     2)
}));

recipes.Add(new Recipe(ItemsId.Dragon_Armor, new List<(ItemsId, int)>
{
    (ItemsId.DragonScale, 6),
    (ItemsId.GoldIngot,   4),
    (ItemsId.RuneStone,   2),
    (ItemsId.Leather,     4)
}));

recipes.Add(new Recipe(ItemsId.Dragon_Gauntlets, new List<(ItemsId, int)>
{
    (ItemsId.DragonScale, 2),
    (ItemsId.GoldIngot,   2),
    (ItemsId.Leather,     2)
}));

recipes.Add(new Recipe(ItemsId.Dragon_Leggings, new List<(ItemsId, int)>
{
    (ItemsId.DragonScale, 4),
    (ItemsId.GoldIngot,   3),
    (ItemsId.RuneStone,   1),
    (ItemsId.Leather,     3)
}));

recipes.Add(new Recipe(ItemsId.Dragon_Boots, new List<(ItemsId, int)>
{
    (ItemsId.DragonScale, 3),
    (ItemsId.GoldIngot,   2),
    (ItemsId.Leather,     2)
}));

recipes.Add(new Recipe(ItemsId.Dragon_Shield, new List<(ItemsId, int)>
{
    (ItemsId.DragonScale, 5),
    (ItemsId.GoldIngot,   3),
    (ItemsId.RuneStone,   2),
    (ItemsId.Wood,        2)
}));


// ─────────────────────────────────────────────
// ARMOR — Tier 7 · Mythic  (Celestial)
// DragonScale + AncientRelic + GoldIngot + MagicDust
// ─────────────────────────────────────────────

recipes.Add(new Recipe(ItemsId.Celestial_Helm, new List<(ItemsId, int)>
{
    (ItemsId.DragonScale, 4),
    (ItemsId.AncientRelic,2),
    (ItemsId.GoldIngot,   4),
    (ItemsId.MagicDust,   6)
}));

recipes.Add(new Recipe(ItemsId.Celestial_Armor, new List<(ItemsId, int)>
{
    (ItemsId.DragonScale, 8),
    (ItemsId.AncientRelic,4),
    (ItemsId.GoldIngot,   8),
    (ItemsId.MagicDust,  10)
}));

recipes.Add(new Recipe(ItemsId.Celestial_Gloves, new List<(ItemsId, int)>
{
    (ItemsId.DragonScale, 3),
    (ItemsId.AncientRelic,2),
    (ItemsId.GoldIngot,   3),
    (ItemsId.MagicDust,   5)
}));

recipes.Add(new Recipe(ItemsId.Celestial_Leggings, new List<(ItemsId, int)>
{
    (ItemsId.DragonScale, 6),
    (ItemsId.AncientRelic,3),
    (ItemsId.GoldIngot,   6),
    (ItemsId.MagicDust,   8)
}));

recipes.Add(new Recipe(ItemsId.Celestial_Boots, new List<(ItemsId, int)>
{
    (ItemsId.DragonScale, 4),
    (ItemsId.AncientRelic,2),
    (ItemsId.GoldIngot,   4),
    (ItemsId.MagicDust,   6)
}));

    }

    public void CraftMenu(Player player, Floor floor)
    {
        Console.WriteLine("---------------------------");
        Console.WriteLine("      Craft and Recipes    ");
        Console.WriteLine("---------------------------");
        Console.WriteLine("1. Eşya Üret \n2. Tarif Kitabı");


        Console.Write("Seçim: ");
        string? firstSelect = Console.ReadLine();

        switch (firstSelect)
        {
            case "1":


        Console.WriteLine("---------------------------");
        Console.WriteLine("      Doable Recipes");
        Console.WriteLine("---------------------------");


        var MaterialItemListInBag = new List<(Item item, int amount)>();

        //Materyal itemleri listeye alma işlemi
        foreach(var material in player.GetAllItemsList())
        {
            
            if(material.Type == ItemType.Material) {

                if(!MaterialItemListInBag.Select(x => x.item.Id).Contains(material.Id)){

                    MaterialItemListInBag.Add((material, player.GetItemAmountInBag(material.Id)));

            }}else continue;}
       
        // Recipe içindeki gereklilikleri material listesi ile karşılaştırma

        var DoableRecipes = recipes
        .Where(recipe => recipe.RequiredItems
            .All(required => MaterialItemListInBag
            .Any(bagItem => bagItem.item.Id == required.itemsid 
                         && bagItem.amount >= required.amount)))
            .ToList();
        
        
        
        
        for(int i = 0; i <  DoableRecipes.Count(); i++){
        Console.WriteLine($"{i + 1}. {DoableRecipes[i]}");
        }

        if(DoableRecipes.Count() <= 0 ) {
        Console.WriteLine("Henüz üretebileceğin bir eşya yok");
        break;
        }
        Console.Write("Eşya Seçim: ");
        string? craftSelect = Console.ReadLine();

        if (!int.TryParse(craftSelect, out int result))
        {
            Console.WriteLine("Geçersiz seçim.");
            break;
        }

        if (result <= 0 || result > DoableRecipes.Count)
        {
            Console.WriteLine("Geçersiz seçim.");
            break;
        }

        Recipe selectedRecipe = DoableRecipes[result - 1];
        Item resultItem = itemdatabase.CreateItem(selectedRecipe.ResultItemId);
        

        Craft(resultItem, selectedRecipe, player, floor);
        

                break;
        

        case "2":

        for (int i = 0; i < recipes.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {recipes[i]}");
        }

            break;


        default:
            Console.WriteLine("Geçersiz Seçim");
            break;


        }
    }
    
    private void Craft(Item resultItem, Recipe recipe, Player player, Floor floor)
    {
        if (!CanCraft(recipe, player))
        {
            Console.WriteLine("Bu eşyayı yapmak için yeterli malzemen yok!");
            return;
        }

        if (!ConsumeMaterials(recipe, player))
        {
            Console.WriteLine("İtem harcama başarısız.");
            return;
        }

        Console.WriteLine($"{resultItem.Name} oluşturuldu!");

        int isAdded = player.AddPlayerInventory(resultItem, 1);

        if (isAdded > 0)
        {
            floor.AddItemToFloor(resultItem);
            Console.WriteLine($"{resultItem.Name} envanter dolu olduğu için yere bırakıldı.");
        }
    }

    private bool CanCraft(Recipe recipe, Player player)
    {
        foreach (var requiredItem in recipe.RequiredItems)
        {
            if (player.GetItemAmountInBag(requiredItem.itemsid) < requiredItem.amount)
            {
                return false;
            }
        }

        return true;
    }

    private bool ConsumeMaterials(Recipe recipe, Player player)
    {
        foreach (var requiredItem in recipe.RequiredItems)
        {
            bool spent = player.SpendFromBag(requiredItem.itemsid, requiredItem.amount);

            if (!spent)
            {
                return false;
            }

            Console.WriteLine($"{requiredItem.itemsid} x{requiredItem.amount} harcandı.");
        }

        return true;
    }
}