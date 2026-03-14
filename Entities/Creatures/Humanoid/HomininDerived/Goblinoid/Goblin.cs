using FirstRPG.Entities.Items;
using FirstRPG.Entities.Items.Materials;

public class Goblin : Humanoid

 


{

    ItemDropSystem itemDropSystem;


    private static int healt = 100;
    public static double Attackpower = 8;
    private static Bag bag = new Bag();
    public static bool isdead = false;

// body parts

    public static  Armor? headArmor { get; set; }
    public static  Armor? bodyArmor { get; set; }
    public static  Armor? handArmor { get; set; }
    public static  Armor? legArmor { get; set; }
    public static  Armor? feetArmor { get; set; }
    public static  Armor? shield { get; set; }
    public static Weapon? equippedWeapon { get; set; }

    public Goblin ( Floor floor) : 
    base("Goblin", healt, floor, bag, headArmor, bodyArmor, handArmor, legArmor, feetArmor, shield, equippedWeapon,Attackpower,isdead)
    {
        
        itemDropSystem = new ItemDropSystem();

    }

  
    
}