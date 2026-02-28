public class Goblin : Entity
{

    protected static int Hp = 50;
    protected static string Name = "Goblin";


    public Goblin(Floor floor) : base(Name, Hp, new string[]{"Stone","Stick","item1","item2","item3","item4","item5","item6","item7","item8","item9","item10","item11"},floor)
    {
        
    }



    
}