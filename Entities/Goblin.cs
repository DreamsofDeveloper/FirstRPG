public class Goblin : Entity
{

    protected static int Hp = 50;
    protected static string Name = "Goblin";


    public Goblin(Floor floor) : base(Name, Hp, new List<FirstRPG.Entities.Items.Item>,floor)
    {
        
    }



    
}