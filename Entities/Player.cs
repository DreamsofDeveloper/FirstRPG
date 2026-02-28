using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;


public class Player
{
    
private int level = 0 ;
private int healt;
public int AttackPower;
private InventorySystems inv;

public Player(int healt, int AttackPower, InventorySystems inv)
    {
        this.healt = healt;
        this.AttackPower = AttackPower;
        this.inv = inv;
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
        string item = floor.collectableItems[i];
        bool canCollect = !inv.IsFull() || inv.ReturnKey(item);

        if (canCollect)
        {
            inv.AddToInventory(item);
            Console.WriteLine("Toplanan Eşya: " + item);
            floor.collectableItems.RemoveAt(i);
        }
    }
}

     public bool SpendFromInventory(string item, int amount)
       
    {
        bool TrygetValue = inv.ReturnKey(item);
        int have = inv.ReturnHave(item);
        int left;

        

        if (TrygetValue && have >= amount )
        {
            left = have - amount;

            if (left == 0) inv.RemoveItem(item);

            else {
                
                inv.UpdateItem (item,amount);
                
                }

            return true;

        }else return false;


        
        
       
    }

    public void AddPlayerInventory(string item, int amount)
       {

        
         if(!inv.IsFull()){
            inv.AddToInventory(item,amount);
            Console.WriteLine("Toplanan Eşya: " + item);

        }

        else if(inv.ReturnKey(item))
            {
            inv.AddToInventory(item,amount);
            Console.WriteLine("Toplanan Eşya: " + item);
            }
    }



}