using System.Runtime.CompilerServices;

namespace FirstRPG.Entities.Items{
public abstract class Item
{
    protected int Id {get;}
    protected string Name {get;}
    protected string Description{get;}
    protected int Value{get;}
    protected bool IsStackable{get;}
    protected int MaxStack{get;}
    protected string Rarity{get;}
    protected bool IsSellable{get;}
    protected bool IsDroppable{get;}
    protected string Type{get;}
    

    public Item (int id, string name, string description, int value, bool isStackable, int maxStack, string rarity, bool isSellable, bool isDroppable,string type)
    {
        this.Id = id;
        this.Name = name;
        this.Description = description;
        this.Value = value;
        this.IsStackable = isStackable;
        this.MaxStack = maxStack;
        this.Rarity = rarity;
        this.IsSellable = isSellable;
        this.IsDroppable = isDroppable;
        this.Type = type;

    }








}
}