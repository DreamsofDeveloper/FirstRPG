using System;
using System.Collections.Generic;

public class InventorySystems
{
    private readonly Dictionary<string, int> inventory = new Dictionary<string, int>();

    private readonly string[] itemsForDrop = { "Stone", "Stick", "Diamond" };
    private readonly Random randomLoot = new Random();

    private readonly List<string> collectibleItems = new List<string>();

    public void Attack()
    {
        Console.WriteLine("Düşmana Saldırı Yapıldı!");

        int droppedItemIndex = randomLoot.Next(0, itemsForDrop.Length);
        string collectibleItem = itemsForDrop[droppedItemIndex];

        Console.WriteLine("Düşen Eşya: " + collectibleItem);
        collectibleItems.Add(collectibleItem);
    }

    public void CollectItems()
    {
        if (collectibleItems.Count == 0)
        {
            Console.WriteLine("Toplanacak eşya yok. Önce saldır!");
            return;
        }

        foreach (string item in collectibleItems)
        {
            AddToInventory(item);
            Console.WriteLine("Toplanan Eşya: " + item);
        }

        collectibleItems.Clear();
    }

    public void PrintInventory()
    {
        Console.WriteLine("---------------------------\n        Envanter        \n---------------------------\n");

        if (inventory.Count == 0)
        {
            Console.WriteLine("(Envanter boş)");
            return;
        }

        foreach (var (key, value) in inventory)
            Console.WriteLine($"{key}: {value} adet");
    }

    public void CraftMenu()
    {
        Console.WriteLine("---------------------------\n        Craft        \n---------------------------\n");

        string craftMenu =
            "1. Stone Sword --> (1 Stick, 3 Stone)\n" +
            "2. Stone Axe --> (2 Stick, 3 Stone)\n" +
            "3. Stone Pickaxe --> (2 Stick, 3 Stone)\n" +
            "4. Stone Shovel --> (2 Stick, 1 Stone)\n";

        Console.WriteLine(craftMenu);
        string craftSelect = Console.ReadLine();

        switch (craftSelect)
        {
            case "1":
                Craft("Stone Sword", stone: 3, stick: 1);
                break;

            case "2":
                Craft("Stone Axe", stone: 3, stick: 2);
                break;

            case "3":
                Craft("Stone Pickaxe", stone: 3, stick: 2);
                break;

            case "4":
                Craft("Stone Shovel", stone: 1, stick: 2);
                break;

            default:
                Console.WriteLine("Geçersiz seçim yaptınız, lütfen listede yer alan bir eşyayı seçiniz!");
                break;
        }
    }

    private void Craft(string resultItem, int stone, int stick)
    {
        // Malzemeler yeterliyse harca ve ürünü ekle
        if (SpendFromInventory("Stone", stone) && SpendFromInventory("Stick", stick))
        {
            AddToInventory(resultItem, 1);
            Console.WriteLine($"{resultItem} oluşturuldu!");
        }
        else
        {
          
            Console.WriteLine("Bu eşyayı yapmak için yeterli malzemen yok!");
        }
    }

    private void AddToInventory(string item, int amount = 1)
    {
        if (inventory.ContainsKey(item)) inventory[item] += amount;
        else inventory[item] = amount;
    }

    private bool SpendFromInventory(string item, int amount)
    {
        if (!inventory.TryGetValue(item, out int have) || have < amount) return false;

        int left = have - amount;
        if (left == 0) inventory.Remove(item);
        else inventory[item] = left;
        
        return true;
    }
}