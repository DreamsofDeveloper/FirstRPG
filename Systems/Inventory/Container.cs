using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using FirstRPG.Entities.Items;

public abstract class Container
{
    
private  int _Capacity;
protected string ContainerName;


private readonly List<Slot> _Slots;





public Container(int _capacity, string container_name)
    {
        _Capacity = _capacity;
        ContainerName = container_name;



        _Slots = new List<Slot>(_capacity);

        for( int i = 0; i < _capacity; i++)
        {
            _Slots.Add(new Slot());
        }



    

    }


 public int AddItem(Item item, int amount)
    {
        
             if (amount <= 0) return 0;
           
            // var olan itemi stackle, ekleneni amonuttan düş

        for ( int i = 0; i < _Slots.Count && amount > 0; i++)
        {
            var slot = _Slots[i];
            if(!slot.CanStack(item)) continue;


            int added = slot.AddToExisting(amount);
            amount -= added;
        }

       // yeni slota ekle

       for ( int i = 0; i < _Slots.Count && amount > 0; i++)
        {
            
            var slot = _Slots[i];

            if(!slot.IsEmpty) continue;

            int put = slot.NewStack(item, amount);
            amount -= put;
        } 

        if(amount > 0 ) Console.WriteLine($"{ContainerName} dolu, item alınamadı !");
        // Kalan miktar 0 dan büyük ise, çanta tamamen dolmuştur.
        return amount;


  

       

    }
        // Slottan item sil
public bool SpendFromInventory(int itemId, int amount)
{
    if (amount <= 0) return true;

    // önce yeterli mi kontrol (toplam)
    int total = 0;
    for (int i = 0; i < _Slots.Count; i++)
    {
        var s = _Slots[i];
        if (s.Item != null && s.Item.Id == itemId)
            total += s.Amount;
    }
    if (total < amount) return false;

    // sonra slot slot düş
    int remaining = amount;
    for (int i = 0; i < _Slots.Count && remaining > 0; i++)
    {
        var s = _Slots[i];
        if (s.Item == null || s.Item.Id != itemId) continue;

        int removed = s.RemoveFromSlot(remaining);
        remaining -= removed;
    }

    return true;
}

    
/*
    public List<Slot> GetAllItems()
    {
           return _Slots;
          
    }
*/
  public bool ItemExist(int itemId) => ItemAmount(itemId) > 0;

public int ItemAmount(int itemId)
{
    int total = 0;

    for (int i = 0; i < _Slots.Count; i++)
    {
        var slot = _Slots[i];

        if (slot.Item != null && slot.Item.Id == itemId)
        {
            total += slot.Amount;
        }
    }

    return total;
}
    public void Print()
    {
        Console.WriteLine($"--------------- {ContainerName} ---------------");
        for (int i = 0; i<_Slots.Count; i++)
        {
            
            Console.WriteLine($"Slot {i + 1 }: {_Slots[i]}" );
        }
        Console.WriteLine($"-----------------------------------");
    }








}

