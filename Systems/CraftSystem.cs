using FirstRPG.Entities.Items;

public class CraftSystem
{
    private readonly ItemDatabase itemdatabase;
    private readonly List<Recipe> recipes = new();

    public CraftSystem()
    {
        itemdatabase = new ItemDatabase();

        recipes.Add(
            new Recipe(ItemsId.Wooden_Sword, new List<(ItemsId, int)>
            {
                (ItemsId.Stick, 1),
                (ItemsId.Wood, 2)
            }));

        recipes.Add(
            new Recipe(ItemsId.Iron_Sword, new List<(ItemsId, int)>
            {
                (ItemsId.Stick, 1),
                (ItemsId.IronOre, 2)
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