using FirstRPG.Entities.Items;

public class CraftSystem
{
    private readonly ItemDatabase itemdatabase;
    private readonly List<Recipe> recipes = new();

    public CraftSystem()
    {
        itemdatabase = new ItemDatabase();

       

// ─────────────────────────────────────────────
// WEAPONS — Tier 1 · Common
// ─────────────────────────────────────────────

recipes.Add(new Recipe(ItemsId.Wooden_Sword, new List<(ItemsId, int)>
{
    (ItemsId.Stick, 1),
    (ItemsId.Wood,  2)
}));

recipes.Add(new Recipe(ItemsId.Wooden_Club, new List<(ItemsId, int)>
{
    (ItemsId.Wood,  3)
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
    (ItemsId.IronOre, 3),
    (ItemsId.Coal,    2),
    (ItemsId.Stick,   1)
}));

recipes.Add(new Recipe(ItemsId.Iron_Dagger, new List<(ItemsId, int)>
{
    (ItemsId.IronOre, 2),
    (ItemsId.Coal,    1),
    (ItemsId.Stick,   1)
}));

recipes.Add(new Recipe(ItemsId.Iron_Spear, new List<(ItemsId, int)>
{
    (ItemsId.IronOre, 2),
    (ItemsId.Coal,    1),
    (ItemsId.Wood,    2)
}));

recipes.Add(new Recipe(ItemsId.Iron_Axe, new List<(ItemsId, int)>
{
    (ItemsId.IronOre, 3),
    (ItemsId.Coal,    2),
    (ItemsId.Wood,    1)
}));

recipes.Add(new Recipe(ItemsId.Iron_Mace, new List<(ItemsId, int)>
{
    (ItemsId.IronOre, 4),
    (ItemsId.Coal,    2),
    (ItemsId.Stick,   1)
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
    (ItemsId.IronOre, 4),
    (ItemsId.Coal,    2),
    (ItemsId.Wood,    1)
}));

// ─────────────────────────────────────────────
// WEAPONS — Tier 3 · Rare  (Steel)
// Steel = Iron işlenmiş + Coal;  IronOre gerektirir
// ─────────────────────────────────────────────

recipes.Add(new Recipe(ItemsId.Steel_Sword, new List<(ItemsId, int)>
{
    (ItemsId.IronOre, 5),
    (ItemsId.Coal,    4),
    (ItemsId.Leather, 1)
}));

recipes.Add(new Recipe(ItemsId.Steel_Dagger, new List<(ItemsId, int)>
{
    (ItemsId.IronOre, 3),
    (ItemsId.Coal,    3),
    (ItemsId.Leather, 1)
}));

recipes.Add(new Recipe(ItemsId.Steel_Spear, new List<(ItemsId, int)>
{
    (ItemsId.IronOre, 4),
    (ItemsId.Coal,    3),
    (ItemsId.Wood,    2)
}));

recipes.Add(new Recipe(ItemsId.Steel_Axe, new List<(ItemsId, int)>
{
    (ItemsId.IronOre, 5),
    (ItemsId.Coal,    4),
    (ItemsId.Wood,    1)
}));

recipes.Add(new Recipe(ItemsId.Steel_Mace, new List<(ItemsId, int)>
{
    (ItemsId.IronOre, 6),
    (ItemsId.Coal,    4),
    (ItemsId.Leather, 1)
}));

recipes.Add(new Recipe(ItemsId.War_Bow, new List<(ItemsId, int)>
{
    (ItemsId.Wood,    4),
    (ItemsId.Leather, 3),
    (ItemsId.IronOre, 1)   // metal uç
}));

recipes.Add(new Recipe(ItemsId.Adept_Staff, new List<(ItemsId, int)>
{
    (ItemsId.Wood,    3),
    (ItemsId.Crystal, 2),
    (ItemsId.MagicDust, 1)
}));

recipes.Add(new Recipe(ItemsId.Knight_GreatSword, new List<(ItemsId, int)>
{
    (ItemsId.IronOre,  6),
    (ItemsId.Coal,     5),
    (ItemsId.Leather,  2)
}));

// ─────────────────────────────────────────────
// WEAPONS — Tier 4 · Epic
// Epic = Steel malzeme + nadir organik bileşenler
// ─────────────────────────────────────────────

recipes.Add(new Recipe(ItemsId.Dragon_Slayer, new List<(ItemsId, int)>
{
    (ItemsId.IronOre,    8),
    (ItemsId.Coal,       6),
    (ItemsId.DragonScale,2),
    (ItemsId.BeastFang,  1)
}));

recipes.Add(new Recipe(ItemsId.Assassin_Dagger, new List<(ItemsId, int)>
{
    (ItemsId.IronOre,   5),
    (ItemsId.Coal,      4),
    (ItemsId.SpiderSilk,2),
    (ItemsId.Obsidian,  1)
}));

recipes.Add(new Recipe(ItemsId.Knight_Halberd, new List<(ItemsId, int)>
{
    (ItemsId.IronOre,  8),
    (ItemsId.Coal,     6),
    (ItemsId.Wood,     2),
    (ItemsId.Leather,  2)
}));

recipes.Add(new Recipe(ItemsId.War_Axe, new List<(ItemsId, int)>
{
    (ItemsId.IronOre,  8),
    (ItemsId.Coal,     6),
    (ItemsId.BeastFang,1)
}));

recipes.Add(new Recipe(ItemsId.Skull_Crusher, new List<(ItemsId, int)>
{
    (ItemsId.IronOre,   8),
    (ItemsId.Coal,      6),
    (ItemsId.Bone,      4),
    (ItemsId.Obsidian,  1)
}));

recipes.Add(new Recipe(ItemsId.Elven_Bow, new List<(ItemsId, int)>
{
    (ItemsId.Wood,     5),
    (ItemsId.SpiderSilk,3),
    (ItemsId.Crystal,  2),
    (ItemsId.Feather,  4)
}));

recipes.Add(new Recipe(ItemsId.Arcane_Staff, new List<(ItemsId, int)>
{
    (ItemsId.Wood,     3),
    (ItemsId.Crystal,  3),
    (ItemsId.MagicDust,3),
    (ItemsId.RuneStone,1)
}));

recipes.Add(new Recipe(ItemsId.Blood_Mace, new List<(ItemsId, int)>
{
    (ItemsId.IronOre,  8),
    (ItemsId.Coal,     6),
    (ItemsId.BeastFang,2),
    (ItemsId.Bone,     3)
}));

// ─────────────────────────────────────────────
// WEAPONS — Tier 5 · Legendary
// Legendary = Epic malzeme + AncientRelic / DragonScale / SilverOre/GoldOre
// ─────────────────────────────────────────────

recipes.Add(new Recipe(ItemsId.Phoenix_Blade, new List<(ItemsId, int)>
{
    (ItemsId.GoldOre,     4),
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
    (ItemsId.GoldOre,     3),
    (ItemsId.Crystal,     4),
    (ItemsId.RuneStone,   2),
    (ItemsId.MagicDust,   4)
}));

recipes.Add(new Recipe(ItemsId.Titan_Axe, new List<(ItemsId, int)>
{
    (ItemsId.GoldOre,     5),
    (ItemsId.DragonScale, 2),
    (ItemsId.AncientRelic,1),
    (ItemsId.Coal,        6)
}));

recipes.Add(new Recipe(ItemsId.Thunder_Hammer, new List<(ItemsId, int)>
{
    (ItemsId.GoldOre,     5),
    (ItemsId.Crystal,     4),
    (ItemsId.RuneStone,   3),
    (ItemsId.MagicDust,   5)
}));

recipes.Add(new Recipe(ItemsId.Celestial_Bow, new List<(ItemsId, int)>
{
    (ItemsId.SilverOre,   4),
    (ItemsId.SpiderSilk,  5),
    (ItemsId.Crystal,     4),
    (ItemsId.Feather,     6)
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
    (ItemsId.GoldOre,     5),
    (ItemsId.DragonScale, 3),
    (ItemsId.MagicDust,   5),
    (ItemsId.RuneStone,   2)
}));

// ─────────────────────────────────────────────
// WEAPONS — Tier 6 · Mythic
// Mythic = Legendary bileşenler + AncientRelic + DragonScale
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
    (ItemsId.GoldOre,     6),
    (ItemsId.DragonScale, 5),
    (ItemsId.AncientRelic,3),
    (ItemsId.RuneStone,   4)
}));

recipes.Add(new Recipe(ItemsId.World_Breaker, new List<(ItemsId, int)>
{
    (ItemsId.GoldOre,     8),
    (ItemsId.DragonScale, 6),
    (ItemsId.AncientRelic,4),
    (ItemsId.Coal,        8)
}));

recipes.Add(new Recipe(ItemsId.Doom_Hammer, new List<(ItemsId, int)>
{
    (ItemsId.GoldOre,     8),
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
    (ItemsId.GoldOre,     6),
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
    (ItemsId.GoldOre,     7),
    (ItemsId.DragonScale, 6),
    (ItemsId.AncientRelic,4),
    (ItemsId.RuneStone,   5)
}));

// ─────────────────────────────────────────────
// ARMOR — Tier 1 · Common  (Cloth)
// ─────────────────────────────────────────────

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
    (ItemsId.IronOre, 3),
    (ItemsId.Coal,    2),
    (ItemsId.Leather, 1)
}));

recipes.Add(new Recipe(ItemsId.Iron_Armor, new List<(ItemsId, int)>
{
    (ItemsId.IronOre, 6),
    (ItemsId.Coal,    4),
    (ItemsId.Leather, 2)
}));

recipes.Add(new Recipe(ItemsId.Iron_Gloves, new List<(ItemsId, int)>
{
    (ItemsId.IronOre, 2),
    (ItemsId.Coal,    1),
    (ItemsId.Leather, 1)
}));

recipes.Add(new Recipe(ItemsId.Iron_Leggings, new List<(ItemsId, int)>
{
    (ItemsId.IronOre, 4),
    (ItemsId.Coal,    3),
    (ItemsId.Leather, 1)
}));

recipes.Add(new Recipe(ItemsId.Iron_Boots, new List<(ItemsId, int)>
{
    (ItemsId.IronOre, 3),
    (ItemsId.Coal,    2),
    (ItemsId.Leather, 1)
}));

recipes.Add(new Recipe(ItemsId.Iron_Shield, new List<(ItemsId, int)>
{
    (ItemsId.IronOre, 5),
    (ItemsId.Coal,    3),
    (ItemsId.Wood,    1)
}));

// ─────────────────────────────────────────────
// ARMOR — Tier 4 · Rare  (Steel)
// ─────────────────────────────────────────────

recipes.Add(new Recipe(ItemsId.Steel_Helmet, new List<(ItemsId, int)>
{
    (ItemsId.IronOre, 4),
    (ItemsId.Coal,    4),
    (ItemsId.Leather, 1)
}));

recipes.Add(new Recipe(ItemsId.Steel_Armor, new List<(ItemsId, int)>
{
    (ItemsId.IronOre, 8),
    (ItemsId.Coal,    6),
    (ItemsId.Leather, 2)
}));

recipes.Add(new Recipe(ItemsId.Steel_Gloves, new List<(ItemsId, int)>
{
    (ItemsId.IronOre, 3),
    (ItemsId.Coal,    3),
    (ItemsId.Leather, 1)
}));

recipes.Add(new Recipe(ItemsId.Steel_Leggings, new List<(ItemsId, int)>
{
    (ItemsId.IronOre, 6),
    (ItemsId.Coal,    5),
    (ItemsId.Leather, 1)
}));

recipes.Add(new Recipe(ItemsId.Steel_Boots, new List<(ItemsId, int)>
{
    (ItemsId.IronOre, 4),
    (ItemsId.Coal,    4),
    (ItemsId.Leather, 1)
}));

recipes.Add(new Recipe(ItemsId.Steel_Shield, new List<(ItemsId, int)>
{
    (ItemsId.IronOre, 7),
    (ItemsId.Coal,    5),
    (ItemsId.Wood,    1)
}));

// ─────────────────────────────────────────────
// ARMOR — Tier 5 · Epic  (Knight)
// ─────────────────────────────────────────────

recipes.Add(new Recipe(ItemsId.Knight_Helm, new List<(ItemsId, int)>
{
    (ItemsId.IronOre,  6),
    (ItemsId.Coal,     5),
    (ItemsId.BeastFang,1),
    (ItemsId.Leather,  2)
}));

recipes.Add(new Recipe(ItemsId.Knight_Armor, new List<(ItemsId, int)>
{
    (ItemsId.IronOre,  12),
    (ItemsId.Coal,     8),
    (ItemsId.BeastFang,2),
    (ItemsId.Leather,  4)
}));

recipes.Add(new Recipe(ItemsId.Knight_Gauntlets, new List<(ItemsId, int)>
{
    (ItemsId.IronOre,  5),
    (ItemsId.Coal,     4),
    (ItemsId.Leather,  2)
}));

recipes.Add(new Recipe(ItemsId.Knight_Leggings, new List<(ItemsId, int)>
{
    (ItemsId.IronOre,  8),
    (ItemsId.Coal,     6),
    (ItemsId.BeastFang,1),
    (ItemsId.Leather,  3)
}));

recipes.Add(new Recipe(ItemsId.Knight_Boots, new List<(ItemsId, int)>
{
    (ItemsId.IronOre,  6),
    (ItemsId.Coal,     5),
    (ItemsId.Leather,  2)
}));

recipes.Add(new Recipe(ItemsId.Knight_Shield, new List<(ItemsId, int)>
{
    (ItemsId.IronOre,  10),
    (ItemsId.Coal,     7),
    (ItemsId.Wood,     2),
    (ItemsId.BeastFang,1)
}));

// ─────────────────────────────────────────────
// ARMOR — Tier 6 · Legendary  (Dragon)
// ─────────────────────────────────────────────

recipes.Add(new Recipe(ItemsId.Dragon_Helm, new List<(ItemsId, int)>
{
    (ItemsId.DragonScale, 3),
    (ItemsId.GoldOre,     2),
    (ItemsId.RuneStone,   1),
    (ItemsId.Leather,     2)
}));

recipes.Add(new Recipe(ItemsId.Dragon_Armor, new List<(ItemsId, int)>
{
    (ItemsId.DragonScale, 6),
    (ItemsId.GoldOre,     4),
    (ItemsId.RuneStone,   2),
    (ItemsId.Leather,     4)
}));

recipes.Add(new Recipe(ItemsId.Dragon_Gauntlets, new List<(ItemsId, int)>
{
    (ItemsId.DragonScale, 2),
    (ItemsId.GoldOre,     2),
    (ItemsId.Leather,     2)
}));

recipes.Add(new Recipe(ItemsId.Dragon_Leggings, new List<(ItemsId, int)>
{
    (ItemsId.DragonScale, 4),
    (ItemsId.GoldOre,     3),
    (ItemsId.RuneStone,   1),
    (ItemsId.Leather,     3)
}));

recipes.Add(new Recipe(ItemsId.Dragon_Boots, new List<(ItemsId, int)>
{
    (ItemsId.DragonScale, 3),
    (ItemsId.GoldOre,     2),
    (ItemsId.Leather,     2)
}));

recipes.Add(new Recipe(ItemsId.Dragon_Shield, new List<(ItemsId, int)>
{
    (ItemsId.DragonScale, 5),
    (ItemsId.GoldOre,     3),
    (ItemsId.RuneStone,   2),
    (ItemsId.Wood,        2)
}));

// ─────────────────────────────────────────────
// ARMOR — Tier 7 · Mythic  (Celestial)
// Celestial = DragonScale + AncientRelic + GoldOre + MagicDust
// ─────────────────────────────────────────────

recipes.Add(new Recipe(ItemsId.Celestial_Helm, new List<(ItemsId, int)>
{
    (ItemsId.DragonScale, 4),
    (ItemsId.AncientRelic,2),
    (ItemsId.GoldOre,     4),
    (ItemsId.MagicDust,   6)
}));

recipes.Add(new Recipe(ItemsId.Celestial_Armor, new List<(ItemsId, int)>
{
    (ItemsId.DragonScale, 8),
    (ItemsId.AncientRelic,4),
    (ItemsId.GoldOre,     8),
    (ItemsId.MagicDust,  10)
}));

recipes.Add(new Recipe(ItemsId.Celestial_Gloves, new List<(ItemsId, int)>
{
    (ItemsId.DragonScale, 3),
    (ItemsId.AncientRelic,2),
    (ItemsId.GoldOre,     3),
    (ItemsId.MagicDust,   5)
}));

recipes.Add(new Recipe(ItemsId.Celestial_Leggings, new List<(ItemsId, int)>
{
    (ItemsId.DragonScale, 6),
    (ItemsId.AncientRelic,3),
    (ItemsId.GoldOre,     6),
    (ItemsId.MagicDust,   8)
}));

recipes.Add(new Recipe(ItemsId.Celestial_Boots, new List<(ItemsId, int)>
{
    (ItemsId.DragonScale, 4),
    (ItemsId.AncientRelic,2),
    (ItemsId.GoldOre,     4),
    (ItemsId.MagicDust,   6)
}));

// ─────────────────────────────────────────────
// SHIELDS — Wooden  (Tier 1 · Common)
// ─────────────────────────────────────────────

recipes.Add(new Recipe(ItemsId.Wooden_Shield, new List<(ItemsId, int)>
{
    (ItemsId.Wood,  4),
    (ItemsId.Stick, 2)
}));

    }

    public void CraftMenu(Player player, Floor floor)
    {
        Console.WriteLine("---------------------------");
        Console.WriteLine("          Craft");
        Console.WriteLine("---------------------------");

        for (int i = 0; i < recipes.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {recipes[i]}");
        }

        Console.Write("Seçim: ");
        string? craftSelect = Console.ReadLine();

        if (!int.TryParse(craftSelect, out int result))
        {
            Console.WriteLine("Geçersiz seçim.");
            return;
        }

        if (result <= 0 || result > recipes.Count)
        {
            Console.WriteLine("Geçersiz seçim.");
            return;
        }

        Recipe selectedRecipe = recipes[result - 1];
        Item resultItem = itemdatabase.CreateItem(selectedRecipe.ResultItemId);

        Craft(resultItem, selectedRecipe, player, floor);
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