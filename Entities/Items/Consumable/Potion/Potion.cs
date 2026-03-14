using FirstRPG.Entities.Items;

public class Potion : Item
{


    public Potion(int id, string name, string description, int value, string rarity) :

     base(
        id, name, description, value, true, 10, rarity, true, true, false, ItemType.Potion)
    {
    }
}