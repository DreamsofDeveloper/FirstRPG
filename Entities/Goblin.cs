public class Goblin : Entity
{

    protected static int Hp = 50;
    protected static string Name = "Goblin";


    public Goblin(Floor floor) : base(Name, Hp, new string[]{"Coin","Stone","Stick"}, floor)
    {
        
    }



    
}