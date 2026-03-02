using FirstRPG.Entities.Items;
using FirstRPG.Entities.Items.Materials;

public class Goblin : Entity

{





    protected static int Hp = 50;
    protected static string Name = "Goblin";


    public Goblin(Floor floor) : base(Name, Hp, new int[]{1001,1003} ,floor)
    {
        
    }



    
}