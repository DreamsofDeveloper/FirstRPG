using System.ComponentModel;
using FirstRPG.Entities.Items;

public abstract class Container
{
    
private  int _Capacity;
private int _CurrentSlotCount;
protected string ContainerName;
private bool isFull;
private List<Array> slots = new List<Array>();

protected Item[] slot;




public Container(int _capacity, string container_name)
    {
        _Capacity = _capacity;
        ContainerName = container_name;


    }

public void AddItemInSlot(Item item)
    {
        slot = new Item[_Capacity];
        
        if(!isFull){
        for(int i=0; i<_Capacity; i++)
        {
            if(slot[i] == null)
            {
                return;
            }

            else
            {
                slot[i] = item;
            }
        }
    }
    }


private void IsFull()
    {
        if(slot.Length == _Capacity)
        {
            Console.WriteLine($"{ContainerName} Dolu");
            isFull = true;
        }
        else isFull = false;


    }











}

