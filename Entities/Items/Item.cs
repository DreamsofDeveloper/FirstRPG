namespace FirstRPG.Entities.Items
{
    public abstract class Item
    {
        public ItemsId Id { get; }
        public string Name { get; }
        public string Description { get; }
        public int Value { get; }
        public bool IsStackable { get; }
        public int MaxStack { get; }
        public ItemRarity Rarity { get; }
        public bool IsSellable { get; }
        public bool IsDroppable { get; }
        public ItemType Type { get; }
        public bool Wearable { get; }
        public BaseMaterial BaseMaterial{ get; }

        protected Item(
            ItemsId id,
            string name,
            string description,
            int value,
            bool isStackable,
            int maxStack,
            ItemRarity rarity,
            bool isSellable,
            bool isDroppable,
            bool wearable,
            ItemType type,
            BaseMaterial basematerial
            )
        {
            Id = id;
            Name = name;
            Description = description;
            Value = value;
            IsStackable = isStackable;
            MaxStack = maxStack;
            Rarity = rarity;
            IsSellable = isSellable;
            IsDroppable = isDroppable;
            Wearable = wearable;
            Type = type;
            BaseMaterial = basematerial;
        }
    }
}