using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FirstRPG.Entities.Items;


public class Player: Humanoid
{
    
private int level = 0 ;
private static int healt = 100;
public static double Attackpower = 10;
public static bool isdead = false;
private static Bag bag = new Bag();

// body parts

    public static  Armor? headArmor { get; set; }
    public static  Armor? bodyArmor { get; set; }
    public static  Armor? handArmor { get; set; }
    public static  Armor? legArmor { get; set; }
    public static  Armor? feetArmor { get; set; }
    public static  Armor? shield { get; set; }
    public static Weapon? equippedWeapon { get; set; }

    public Player(string name, Floor floor) : 
    base(name, healt, floor, bag, headArmor, bodyArmor, handArmor, legArmor, feetArmor, shield, equippedWeapon,Attackpower,isdead)
    {
        


    }


     public void CollectItems(Floor floor)
{
            if(floor.IsthereItems()) floor.GiveItems(bag);
            else Console.WriteLine("Yerde Toplanacak Eşya Yok..!");
   


}


    public int AddPlayerInventory(Item item, int amount)
       {
       int left =  bag.AddItem(item,amount);

        return left;

    }

   public void Use()
{
    Console.Write("Kullanmak istediğiniz eşyanın slot numarası, çıkış için '999' : ");
    bool input = int.TryParse(Console.ReadLine(), out int slot);
    if(slot == 999) return;

    if (!input)
    {
        Console.WriteLine("Lütfen geçerli bir numara giriniz!");
        return;
    }

    Item? item = bag.GetItem(slot);

    if (item == null)
    {
       
        return;
    }

   if(item is Weapon weapon)
        {
            equippedWeapon = weapon;
            Console.WriteLine($"{item.Name} kuşanıldı.");
            bag.RemoveItemFromSlot(slot,1);
        }
  else if(item is Armor armor)
        {
            switch (armor.ArmorType)
            {
                case EquipmentsType.HeadArmor:
                    headArmor = armor;
                    Console.WriteLine($"{item.Name} giyinildi.");
                    bag.RemoveItemFromSlot(slot,1);

                    break;
                case EquipmentsType.ChestArmor:
                    bodyArmor = armor;
                    Console.WriteLine($"{item.Name} giyinildi.");
                    bag.RemoveItemFromSlot(slot,1);

                    break;
                case EquipmentsType.LegArmor:
                    legArmor= armor;
                    Console.WriteLine($"{item.Name} giyinildi.");
                    bag.RemoveItemFromSlot(slot,1);

                    break;
                case EquipmentsType.FeetArmor:
                    feetArmor = armor;
                    Console.WriteLine($"{item.Name} giyinildi.");
                    bag.RemoveItemFromSlot(slot,1);

                    break;
                case EquipmentsType.HandArmor:
                    handArmor = armor;
                    Console.WriteLine($"{item.Name} giyinildi.");
                    bag.RemoveItemFromSlot(slot,1);
                    break;
                case EquipmentsType.Shield:
                    shield = armor;
                    Console.WriteLine($"{item.Name} giyinildi.");
                    bag.RemoveItemFromSlot(slot,1);

                    break;
            
            
            default:
                break;
            
            
            
            
            }
        }
    else if(item is Potion potion)
        {
            Console.WriteLine($"{item.Name} iksiri içildi. ");
            bag.RemoveItemFromSlot(slot,1);
        }





    else Console.WriteLine($"{item.Name} bu şekilde kullanılamaz");

}


// Çanta


public bool LookInBag(int itemId)
    {
        return bag.ItemExist(itemId);
    }

public bool SpendFromBag(int itemId, int amount)
    {
        return bag.SpendFromInventory(itemId, amount);
        
    }

public void ReadTheBag()
    {
        bag.Print();

      
        Console.WriteLine("1.Kullan        2.Yere At        3.Sil");
        string input = Console.ReadLine();

        switch (input)
        {
        case "1":
                  
              Use();    
                  
                  break;
        default:
          Console.WriteLine("Böyle bir seçenek yok!");
        break;

        }
    }

}