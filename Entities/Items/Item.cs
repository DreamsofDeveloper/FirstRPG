namespace FirstRPG.Entities.Items
{
    public abstract class Item
    {
        public int Id { get; }
        public string Name { get; }
        public string Description { get; }
        public int Value { get; }
        public bool IsStackable { get; }
        public int MaxStack { get; }
        public string Rarity { get; }
        public bool IsSellable { get; }
        public bool IsDroppable { get; }
        public string Type { get; }

        public Item(
            int id,
            string name,
            string description,
            int value,
            bool isStackable,
            int maxStack,
            string rarity,
            bool isSellable,
            bool isDroppable,
            string type)
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
            Type = type;
        }
    }
}