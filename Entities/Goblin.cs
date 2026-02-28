public class Goblin : Entity
{

    protected static int Hp = 50;
    protected static string Name = "Goblin";


    public Goblin(Floor floor) : base(Name, Hp, new string[]{"Stone", "Stick", "Berry", "Herb", "Iron Ore", "Wood Log", "Crystal Shard", "Mushroom", "Leather Scrap", "Coin Pouch", "Silver Ore", "Magic Dust", "Old Key", "Bone Fragment", "Torch", "Rope", "Flint", "Apple", "Feather", "Water Flask"}, floor)
    {
        
    }



    
}