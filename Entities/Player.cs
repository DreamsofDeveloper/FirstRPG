using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FirstRPG.Entities.Items;


public class Player
{
    
private int level = 0 ;
private int healt;
public int AttackPower;
private PlayerBag bag;

public Player(int healt, int AttackPower,PlayerBag Bag,Floor floor)
    {
        this.healt = healt;
        this.AttackPower = AttackPower;
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



}