  public class CraftSystem
{
    
   

  
  
   public void CraftMenu(Player player,Floor floor, InventorySystems inv)
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
                Craft("Stone Sword", stone: 3, stick: 1, player, floor, inv);
                break;

            case "2":
                Craft("Stone Axe", stone: 3, stick: 2 , player, floor, inv);
                break;

            case "3":
                Craft("Stone Pickaxe", stone: 3, stick: 2, player, floor, inv);
                break;

            case "4":
                Craft("Stone Shovel", stone: 1, stick: 2, player, floor, inv);
                break;

            default:
                Console.WriteLine("Geçersiz seçim yaptınız, lütfen listede yer alan bir eşyayı seçiniz!");
                break;
        }
    }

    private void Craft(string resultItem, int stone, int stick, Player player,Floor floor, InventorySystems inv)
    {
        // Malzemeler yeterliyse harca ve ürünü ekle
        if (player.SpendFromInventory("Stone", stone) && player.SpendFromInventory("Stick", stick))
        {
            if (!inv.IsFull())
            {
                 player.AddPlayerInventory(resultItem,1);
                 
            }
            else
            {
                floor.collectableItems.Add(resultItem);
            }
           
           Console.WriteLine($"{resultItem} oluşturuldu!");

            
        }
        else
        {
          
            Console.WriteLine("Bu eşyayı yapmak için yeterli malzemen yok!");
        }
    }

    }