using FirstRPG.Entities.Items;

public class ItemDropSystem
{

   private readonly ItemDatabase itemdatabase;
   private readonly List<Item> allItems;
   private readonly Floor floor;


public ItemDropSystem(Floor floor)
    {
        itemdatabase = new ItemDatabase();
        allItems = itemdatabase.GetAllItems();
        this.floor = floor;


    }







 public void DropItem(int id, string owner)
{
    if (itemdatabase == null)
    {
        Console.WriteLine("itemdatabase null");
        return;
    }

    if (allItems == null)
    {
        Console.WriteLine("allItems null");
        return;
    }

    if (floor == null)
    {
        Console.WriteLine("floor null");
        return;
    }

    foreach (Item item in allItems)
    {
        if (item == null)
        {
            Console.WriteLine("Listede null item var");
            continue;
        }

        if (id == item.Id)
        {
            floor.ItemsOnTheFloor(item.Name,owner);
        }
    }
}
        

    }




