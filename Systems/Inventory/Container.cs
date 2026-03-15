using System.ComponentModel;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using FirstRPG.Entities.Items;

public abstract class Container
{
    
private  int _Capacity;
protected string ContainerName;
private bool FullTextSize = false;
private int? Lastitem = null;


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

        if (amount > 0)
      {
        if (Lastitem != item.Id)
        {
        Console.WriteLine($"{ContainerName} dolu, {item.Name} alınamadı!");
        Lastitem = item.Id;
        }
    }
     else
    {
           Lastitem = null;
       }
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

    

   public List<Item> ReturnAllItems()
    {
    List<Item> items = new List<Item>();

    for (int i = 0; i < _Slots.Count; i++)
    {
        if (_Slots[i].Item != null)
        {
         for(int x = 0; x < _Slots[i].Amount; x ++){
            items.Add(_Slots[i].Item!);
         }

        }
    }

    return items;
    }

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


    public Item? GetItem(int slotnum)
{
    int index = slotnum - 1;

    if (index < 0 || index >= _Slots.Count)
    {
        Console.WriteLine("Değer içerik dışı");
        return null;
    }

    var holdingitem = _Slots[index].Item;

    if (holdingitem == null)
    {
        Console.WriteLine("Bu slot boş.");
        return null;
    }
    return holdingitem;
}


 public void RemoveItemFromSlot(int slotnum, int amount)
    {
        int index = slotnum -1;
        _Slots[index].RemoveFromSlot(amount);
    }



    






}

