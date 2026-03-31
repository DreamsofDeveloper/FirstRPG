using System.Linq.Expressions;
using FirstRPG.Entities.Items;

public class CraftSystem
{
    
   
   private readonly ItemDatabase itemdatabase;
   private readonly List<Item> allItems;
   private readonly List<Recipe> Recipes = new List<Recipe>();
   

    
  
  public CraftSystem()
    {
        itemdatabase = new ItemDatabase();
        allItems = itemdatabase.GetAllItems();

        Recipes.Add(
            
        new Recipe(ItemsId.Wooden_Sword, new List<(ItemsId, int)>
        {
            (ItemsId.Stick, 1),
            (ItemsId.Wood, 2)
        }));
        Recipes.Add(
        new Recipe(ItemsId.Iron_Sword, new List<(ItemsId, int)>
        {
            (ItemsId.Stick, 1),
            (ItemsId.IronOre,2)
        
        }));
        
        


    }
   public void CraftMenu(Player player,Floor floor)
    {
        Console.WriteLine("---------------------------\n        Craft        \n---------------------------\n");
        for(int i = 0; i < Recipes.Count; i++)
        {
            Console.WriteLine(i+1 + ". " + Recipes[i]);
            
        }
        
                

        Console.Write("Seçim: ");
        string? craftSelect = Console.ReadLine();
        
        bool index = int.TryParse(craftSelect, out int result);

        if (index)
        {
         if(result - 1 <= Recipes.Count) Craft(itemdatabase.CreateItem(Recipes[result -1].ResultItemId), 
         Recipes[result -1], player, floor);
        }else Console.WriteLine("Geçersiz Seçim");

        
    }

    private void Craft(Item resultItem, Recipe recipe, Player player,Floor floor)
    {
        int controlcount = 0;

        // Malzemeler yeterliyse harca ve ürünü ekle
foreach(var item in recipe.RequiredItems){

if(player.LookInBag(item.itemsid))
{
    
        controlcount ++;

if(controlcount == recipe.RequiredItems.Count){

       if (player.SpendFromBag(item.itemsid, item.amount))
{
          Console.WriteLine($"{resultItem.Name} oluşturuldu!");
          int Isadded = player.AddPlayerInventory(resultItem, 1);
          if (Isadded > 0) floor.AddItemToFloor(resultItem);
          controlcount = 0;
}else
{
    Console.WriteLine("Bu eşyayı yapmak için yeterli malzemen yok! 1");
    controlcount = 0;
}
 }else continue;
                

}else
{
    Console.WriteLine("Bu eşyayı yapmak için yeterli malzemen yok! 2");
    controlcount = 0;
}
}

    }

  

    }