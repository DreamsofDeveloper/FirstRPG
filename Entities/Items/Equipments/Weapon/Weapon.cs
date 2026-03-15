using FirstRPG.Entities.Items;

public class Weapon : Item, IDurability
{
    public double Damage { get; set; }
    public double Durability { get; set; }
    public double MaxDurability { get; set; }
    public int RequiredLevel { get; set; }
    public int Level { get; set; }
    public EquipmentsType WeaponType { get; set; }

    public Weapon(
        int id,
        string name,
        string description,
        int value,
        ItemRarity rarity,
        EquipmentsType weaponType,
        double damage,
        double durability,
        double maxDurability,
        int requiredLevel,
        int level,
        BaseMaterial basematerial)
        : base(
            id,
            name,
            description,
            value,
            false,
            1,
            rarity,
            true,
            true,
            true,
            ItemType.Weapon,
            basematerial)
    {
        WeaponType = weaponType;
        Damage = damage;
        Durability = durability;
        MaxDurability = maxDurability;
        RequiredLevel = requiredLevel;
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

    public void UpgradeDamage(double amount)
    {
        Damage += amount;
    }
}