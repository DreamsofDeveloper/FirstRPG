using System.Reflection.Metadata;
using FirstRPG.Entities.Items;

public class Weapon : Item
{


   public const bool  isSellable = true;
   public const bool isStackable = false;
   public const bool  isDroppable = true;
   public const bool wearable = true;
   public const int maxStack = 1;
   public const ItemType type = ItemType.Weapon;

   public double Damage {get; set;}
   public double Durability {get; set;}
   public double MaxDurability {get; set;}
   public int RequiredLevel {get; set;}
   public string WeaponType {get; set;}




    public Weapon(int id, string name, string description, int value,string rarity, string weaponType ,double damage, int durability, int maxdurability, int requiredlevel) : base(id, name, description, value, isStackable, maxStack, rarity, isSellable, isDroppable,wearable, type)
    {

        Damage = damage;
        Durability = durability;
        MaxDurability = maxdurability;
        RequiredLevel = requiredlevel;
        WeaponType = weaponType;

    }
}