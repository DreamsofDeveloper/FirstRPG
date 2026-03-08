using FirstRPG.Entities.Items;
using FirstRPG.Entities.Items.Materials;

public class Goblin : Humanoid

 


{

    ItemDropSystem itemDropSystem;




private const double BaseHp = 50;
private const string BaseName = "Goblin";
private int[] Items = {1001,1003};


    public Goblin(Floor floor) : base(BaseName, BaseHp, floor)
{
    itemDropSystem = new ItemDropSystem(floor);
}


    public override void Die()
    {
        base.Die();
      for(int i = 0; i < Items.Length; i++)
        {
            itemDropSystem.DropItem(Items[i],Name);
        } 
    }
    
}