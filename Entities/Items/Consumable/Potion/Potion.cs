using FirstRPG.Entities.Items;

public class Potion : Item
{


    public Potion(int id, string name, string description, int value, ItemRarity rarity, BaseMaterial basematerial) :

     base(
        id, name, description, value, true, 10, rarity, true, true, false, ItemType.Potion,basematerial)
    {
    }
}