
using FirstRPG.Entities.Items;

namespace FirstRPG.Entities.Items.Materials
{


    public abstract class Material : Item
    {

        public const bool IsDroppable = true;
        public const bool IsStackable = true;
        public const bool wearable = false;
        public const ItemType Type = ItemType.Material;
        protected Material(int id, string name, string description, int value, int maxStack, string rarity, bool isSellable) : base(id, name, description, value, IsStackable, maxStack, rarity, isSellable, IsDroppable,wearable, Type)
        {
            
            
        }
    }
}