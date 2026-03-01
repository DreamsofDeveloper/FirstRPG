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
        }

        public List<Item> GetAllItems()
        {
            return items;
        }
    }
}