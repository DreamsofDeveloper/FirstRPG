using FirstRPG.Entities.Items;

public class WoodenSword : Weapon
{
    public const int id = (int)ItemsId.Wooden_Sword;
    public const string name = "Wooden Sword";
    public const string description = "Ağaçtan yapılma bir kılıç.";
    public const int value = 10;
    public const string rarity = "Low";
    public const int requiredlevel = 1;
    public const EquipmentsType weaponType = EquipmentsType.Sword;
    public const double BaseDamage = 5.0;
    public const double BaseDurability = 5.0;
    public const double BaseMaxDurability = 5.0;
    public const int BaseLevel = 1;

    public WoodenSword()
        : base(
            id,
            name,
            description,
            value,
            rarity,
            weaponType,
            BaseDamage,
            BaseDurability,
            BaseMaxDurability,
            requiredlevel,
            BaseLevel)
    {
    }
}