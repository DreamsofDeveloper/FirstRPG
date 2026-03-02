using System.Reflection.Metadata;
using FirstRPG.Entities.Items;

public class Weapon : Item
{


   public const bool  isSellable = true;
   public const bool isStackable = false;
   public const bool  isDroppable = true;
   public const int maxStack = 1;
   public const string type = "Weapon";

   public int Damage {get; set;}
   public int Durability {get; set;}
   public int MaxDurability {get; set;}
   public int RequiredLevel {get; set;}
   public string WeaponType {get; set;}




    public Weapon(int id, string name, string description, int value,string rarity, string weaponType ,int damage, int durability, int maxdurability, int requiredlevel) : base(id, name, description, value, isStackable, maxStack, rarity, isSellable, isDroppable, type)
    {

        Damage = damage;
        Durability = durability;
        MaxDurability = maxdurability;
        RequiredLevel = requiredlevel;
        WeaponType = weaponType;

    }
}