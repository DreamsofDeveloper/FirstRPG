
using FirstRPG.Entities.Items;

namespace FirstRPG.Entities.Items.Materials
{


    public class Material : Item
    {
        public Material(int id, string name, string description, int value, int maxStack, ItemRarity rarity, bool isSellable,BaseMaterial basematerial) : 
        base(id, name, description, value, true, maxStack, rarity, isSellable, true ,false, ItemType.Material, basematerial)
        {
            
            
        }
    }
}