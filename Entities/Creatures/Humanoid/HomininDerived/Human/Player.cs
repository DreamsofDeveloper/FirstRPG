using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FirstRPG.Entities.Items;


public class Player: Humanoid
{
    
private int level = 0 ;
private int healt;
public double AttackPower;
private Bag bag;
private List<Item> clothes = new List<Item>();

    public Player(string name,double attackpower, double hp, Floor floor,Bag Bag) : base(name, hp, floor)
    {
        AttackPower = attackpower;
        bag = Bag;

    }

    public void Attack()
    {
        
        Console.WriteLine("Kahraman: Düşmana Saldırı Yapıldı!");
        
        
    }

     public void CollectItems(Floor floor)
{
    if (floor.collectableItems.Count == 0)
    {
        Console.WriteLine("Toplanacak eşya yok.");
        return;
    }

    for (int i = floor.collectableItems.Count - 1; i >= 0; i--)
    {
        var item = floor.collectableItems[i];
      
           
            int left = bag.AddItem(item,1);

            if(left > 0)
            {
                return;
            }
             Console.WriteLine("Toplanan Eşya: " + item.Name);
            floor.collectableItems.RemoveAt(i);
            
            
    
    }
}



    public int AddPlayerInventory(Item item, int amount)
       {
       int left =  bag.AddItem(item,amount);

        return left;

    }

     public void Use()
    {
      Console.Write("Kullanmak istediğiniz eşyanın slot numarası: ");
      bool input = int.TryParse(Console.ReadLine(), out int inpt);

        if (input)
        {
            Item ItemForUse = bag.TakeItem(inpt);

            if (ItemForUse != null)
            {
                if(ItemForUse.Type == ItemType.Armor || ItemForUse.Type == ItemType.Potion || ItemForUse.Type == ItemType.Weapon)
                {
                    clothes.Add(ItemForUse);
                    Console.WriteLine($"{ItemForUse.Name} eşyası kullanıldı..");

                }else Console.WriteLine($"{ItemForUse.Name} eşyası, {ItemForUse.Description} Satmak için ve Üretim için kullanılabilir. ");

            }
        }
        else
        {
            Console.WriteLine("Lütfen geçerli bir numara giriniz!");
        }


        
    }



}