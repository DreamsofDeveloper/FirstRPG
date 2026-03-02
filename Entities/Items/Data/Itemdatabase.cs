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
            items.Add(new Weapon(2001,"Wooden Sword","Ağaçtan yapılma bir kılıç.",10,"low","Sword",4,20,20,1));
        }

        public List<Item> GetAllItems()
        {
            return items;
        }
    }
}