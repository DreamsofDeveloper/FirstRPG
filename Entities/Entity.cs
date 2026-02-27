using System;

public abstract class Entity
{
    public string Name;
    public int Hp;
    public string[] ItemsForDrop;
    public bool IsDead = false;

    Random random = new Random();
    Floor floor;
   
    public Entity(string name, int hp, string[] itemsForDrop, Floor floor)
    {
        Name = name;
        Hp = hp;
        ItemsForDrop = itemsForDrop;
        this.floor = floor;
    }

    public void TakeDamage(int amount)
    {
        Hp -= amount;
        Console.WriteLine($"{Name} {amount} hasar aldı. Kalan HP: {Hp}");

        if (Hp <= 0 && !IsDead)
        {
            Die();
        }
    }

    public void Die()
    {
        IsDead = true;
        Console.WriteLine($"{Name} öldü!");
                            
        string droppedItem = DropItem();
        floor.ItemsOnTheFloor(droppedItem);

                        
        
    }

    public string? DropItem()
    {
        if (ItemsForDrop == null || ItemsForDrop.Length == 0)
        {
            return null;
        }

        int index = random.Next(ItemsForDrop.Length);
        string droppedItem = ItemsForDrop[index];

        Console.WriteLine($"Düşen eşya: {droppedItem}");
        return droppedItem;
    }
}