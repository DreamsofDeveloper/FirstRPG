using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FirstRPG.Entities.Items;


public class Player: Humanoid
{
    
private int level = 0 ;
private int healt;
public double AttackPower;
private Bag bag = new Bag();
private List<Item> clothes = new List<Item>();

    public Player(string name,double attackpower, double hp, Floor floor) : base(name, hp, floor)
    {
        AttackPower = attackpower;
      

    }

    public void Attack()
    {
        
        Console.WriteLine("Kahraman: Düşmana Saldırı Yapıldı!");
        
        
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

    switch (item!.Type)
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