using FirstRPG.Entities.Items;
using FirstRPG.Entities.Items.Materials;

public class Goblin : Humanoid
{
    ItemDropSystem itemDropSystem;
    ItemDatabase itemDatabase = new ItemDatabase();
    private int level = 0;
    private LootBag lootBag;


    public Goblin(Floor floor)
        : base("Goblin", 100, floor, new LootBag(), null,null, null, null, null, null, null, 4, false)
    {
        itemDropSystem = new ItemDropSystem(floor);
        lootBag = new LootBag();
        lootBag.AddItem(itemDatabase!.CreateItem(ItemsId.Stone),5);
        lootBag.AddItem(itemDatabase!.CreateItem(ItemsId.Stick),5);
        lootBag.AddItem(itemDatabase!.CreateItem(ItemsId.Wood),5);

        BodyArmor =(Armor) itemDatabase!.CreateItem(ItemsId.Iron_Armor);
        RefreshShieldFromEquipment();
      
    }

    public override List<Item> Loots()
    {
       if (!IsDead)
            return new List<Item>();

       return new List<Item>(lootBag.ReturnAllItems()!);
    }

    public override void Die()
    {

        base.Die();

        foreach(var item in Loots()){
            
            itemDropSystem.DropItem(item,Name);
        }


        
    }
}