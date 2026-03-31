using FirstRPG.Entities.Items;
using System.Collections.Generic;

public class Recipe
{
    

private readonly ItemDatabase itemdatabase = new ItemDatabase();
public ItemsId ResultItemId { get;}
public List<(ItemsId itemsid, int amount)> RequiredItems { get;}


public Recipe(ItemsId resultItemId, List<(ItemsId itemsid, int amount)> requiredItems)
{
    ResultItemId = resultItemId;
    RequiredItems = requiredItems;


}

    public override string ToString()
    {
        
            var requiredItemsText = string.Join(", ", 
            RequiredItems.Select(x => $"{itemdatabase.GetItemNameById(x.itemsid)} x {x.amount}")
            
            );

           return $"{itemdatabase.GetItemNameById(ResultItemId)} ---> {requiredItemsText}";
    }
}