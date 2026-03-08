using FirstRPG.Entities.Items;

public class CraftSystem
{
    
   
   private readonly ItemDatabase itemdatabase;
   private readonly List<Item> allItems;
   

    
  
  public CraftSystem()
    {
        itemdatabase = new ItemDatabase();
        allItems = itemdatabase.GetAllItems();


    }
   public void CraftMenu(Player player,Floor floor, Bag bag)
    {
        Console.WriteLine("---------------------------\n        Craft        \n---------------------------\n");

        string craftMenu =
            "1. Stone Sword --> (1 Stick, 3 Stone)\n" +
            "2. Stone Axe --> (2 Stick, 3 Stone)\n" +
            "3. Stone Pickaxe --> (2 Stick, 3 Stone)\n" +
            "4. Stone Shovel --> (2 Stick, 1 Stone)\n";

        Console.WriteLine(craftMenu);
        string? craftSelect = Console.ReadLine();

        switch (craftSelect)
        {
            case "1":
                Craft(SelectItem((int)ItemsId.Wooden_Sword), neededstone: 3, neededstick: 1, player, floor, bag);
                break;
        /*
            case "2":
                Craft("Stone Axe", stone: 3, stick: 2 , player, floor, bag);
                break;

            case "3":
                Craft("Stone Pickaxe", stone: 3, stick: 2, player, floor, bag);
                break;

            case "4":
                Craft("Stone Shovel", stone: 1, stick: 2, player, floor, bag);
                break;
*/
            default:
                Console.WriteLine("Geçersiz seçim yaptınız, lütfen listede yer alan bir eşyayı seçiniz!");
                break;
        }
    }

    private void Craft(Item resultItem, int neededstone, int neededstick, Player player,Floor floor, Bag bag)
    {
        // Malzemeler yeterliyse harca ve ürünü ekle
if(bag.ItemExist((int)ItemsId.Stone) && bag.ItemExist((int) ItemsId.Stick)){
       if (bag.SpendFromInventory(1001, neededstone) && bag.SpendFromInventory(1003, neededstick))
{
          Console.WriteLine($"{resultItem.Name} oluşturuldu!");
          int Isadded = player.AddPlayerInventory(resultItem, 1);
          if (Isadded > 0) floor.collectableItems.Add(resultItem);
}else
{
    Console.WriteLine("Bu eşyayı yapmak için yeterli malzemen yok!");
}

}else
{
    Console.WriteLine("Bu eşyayı yapmak için yeterli malzemen yok!");
}

    }

    private Item SelectItem(int itemId)
    {
        foreach(Item item in allItems)
        {
            if(item.Id == itemId)
            {
                return item;
            }
        }
        return null;
    }

    }