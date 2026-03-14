using FirstRPG.Entities.Items.Materials;
using System.Collections.Generic;

namespace FirstRPG.Entities.Items
{
    public class ItemDatabase
    {
        private List<Item> items = new List<Item>();
        
       
        public ItemDatabase()
        {
            items.Add(new Stone());
            items.Add(new Stick());
            items.Add(new WoodenSword());
            
        }

        public List<Item> GetAllItems()
        {
            return items;
        
        }
    }
     public enum ItemsId
        {
            Stone = 1001,
            Stick = 1003,
            Wooden_Sword = 2001
            
        }

     public enum ItemType
    {
        Potion,
        Weapon,
        Armor,
        Material
    }
    public enum EquipmentsType
    {
        //Armor
        HeadArmor,
        ChestArmor,
        HandArmor,
        LegArmor,
        FeetArmor,
        Shield,



        //Weapon 
        Sword,
        Axe,
        Bow,
        Staff,
        Dagger,
        Spear,
        Shovel


    }
}  