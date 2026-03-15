using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
using FirstRPG.Entities.Items;

public class Slot
{
    public Item? Item{get; private set;}
    public int Amount {get; private set;}

    public bool IsEmpty => Item == null;
    public int SpaceLeft => IsEmpty ? 0: Item.MaxStack - Amount;

    public bool CanStack(Item item)
    {
        return !IsEmpty 
        && item.IsStackable 
        && Item!.Id == item.Id 
        && Amount < item.MaxStack;
    }


    // Var olana ekle
    public int AddToExisting(int amount)
    {
       int addable = Math.Min(amount,SpaceLeft);
       Amount += addable;
       return addable;
    }
   public int RemoveFromSlot(int amount)
    {
        if (IsEmpty) return 0;

        int removable = Math.Min(amount, Amount);
        Amount -= removable;

        if (Amount == 0)
            Item = null;

        return removable;
    }

   // Yeni stackleme yap.
   public int NewStack(Item item, int amount)
    {
        Item = item;
        int put = Math.Min(amount,item.MaxStack);
        Amount = put;
        return put;



    }

    public override string ToString() => IsEmpty ? "  (Boş)  ": $"{Item!.Name} X {Amount} adet";

}