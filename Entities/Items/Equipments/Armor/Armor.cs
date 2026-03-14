using FirstRPG.Entities.Items;

public class Armor : Item, IDurability
{ public const bool isSellable = true;
    public const bool isStackable = false;
    public const bool isDroppable = true;
    public const bool wearable = true;
    public const int maxStack = 1;
    public const ItemType type = ItemType.Armor;

    public double Protection { get; set; }
    public double Durability { get; set; }
    public double MaxDurability { get; set; }
    public int RequiredLevel { get; set; }
    public int Level { get; set; }
    public EquipmentsType ArmorType { get; set; }

    public Armor(
        int id,
        string name,
        string description,
        int value,
        string rarity,
        EquipmentsType armorType,
        double protection,
        double durability,
        double maxdurability,
        int requiredlevel,
        int level)
        : base(id, name, description, value, isStackable, maxStack, rarity, isSellable, isDroppable, wearable, type)
    {
        Protection = protection;
        Durability = durability;
        MaxDurability = maxdurability;
        RequiredLevel = requiredlevel;
        ArmorType = armorType;
        Level = level;
    }

    public void ReduceDurability(double amount)
    {
        Durability -= amount;

        if (Durability < 0)
            Durability = 0;
    }

    public bool IsBroken()
    {
        return Durability <= 0;
    }

    public void Repair()
    {
        if (Durability < MaxDurability)
            Durability = MaxDurability;
        else
            Console.WriteLine("Zaten dayanıklılık tam.");
    }

    public void UpgradeMaxDurability(int requiredLevel, double amount)
    {
        if (Level >= requiredLevel)
        {
            MaxDurability += amount;
        }
        else
        {
            Console.WriteLine("Bu yükseltme için yetersiz seviye.");
        }
    }
}