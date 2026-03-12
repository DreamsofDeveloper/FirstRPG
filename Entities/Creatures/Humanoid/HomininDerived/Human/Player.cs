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


// Yerden item toplama ve yerde kalan itemleri silme ya da değereni güncelleme

    List<Item> ItemsToRemove = new List<Item>();
    Dictionary<Item, int> ItemToUpdate = new Dictionary<Item, int>();

    foreach( var pair in floor.collectableItems){

        int left  = bag.AddItem(pair.Key, pair.Value);

        if(left == 0)
            {
                Console.WriteLine($"Toplanan Eşya {pair.Key.Name} X {pair.Value}");
                ItemsToRemove.Add(pair.Key);
            }
        else if(left < pair.Value && left > 0)
            {
                int collectedAmount = pair.Value - left;
                Console.WriteLine($"Toplanan Eşya {pair.Key.Name} X {collectedAmount}");
                ItemToUpdate[pair.Key] = left;
                
            }else
                {
                     return;
                    }
    }

foreach(var pair in ItemToUpdate)
        {
            floor.collectableItems[pair.Key] = pair.Value;
        }

foreach(var item in ItemsToRemove)
        {
            floor.collectableItems.Remove(item);
        }


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
        Console.WriteLine("Bu slot boş.");
        return;
    }

    switch (item.Type)
    {
        case ItemType.Weapon:
            clothes.Add(item);
            Console.WriteLine($"{item.Name} kuşanıldı.");
            break;

        case ItemType.Armor:
            clothes.Add(item);
            Console.WriteLine($"{item.Name} giyildi.");
            break;

        case ItemType.Potion:
            clothes.Add(item);
            Console.WriteLine($"{item.Name} kullanıldı.");
            break;

        default:
            Console.WriteLine($"{item.Name} bu şekilde kullanılamaz.");
            break;
    }
}



}