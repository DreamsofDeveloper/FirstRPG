using FirstRPG.Entities.Items;

public class ItemDropSystem
{

   private readonly ItemDatabase itemdatabase;
   private readonly List<Item> allItems;
   private readonly Floor floor;

    public ItemDropSystem()
    {
    }

    public ItemDropSystem(Floor floor)
    {
        itemdatabase = new ItemDatabase();
        allItems = itemdatabase.GetAllItems();
        this.floor = floor;


    }







 public void DropItem(Item item, string owner)

{

            floor.FallingItem(item , owner);
        
    }





}
        






