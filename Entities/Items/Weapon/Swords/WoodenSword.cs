using FirstRPG.Entities.Items;

public class WoodenSword : Weapon


{

    public const int id = (int) ItemsId.Wooden_Sword;
    public const string name = "Wooden Sword";
    public const string description = "Ağaçtan yapılma bir kılıç.";
    public const int value = 10;
    public const string rarity = "Low";
    public const string weaponType = "Sword";
    public const double Basedamage = 5.0;
    public const double Basedurability = 5;
    





    public WoodenSword(int durability, int maxdurability, int requiredlevel) : base(id, name, description, value, rarity, weaponType, Basedamage, durability, maxdurability, requiredlevel)
    {
    }
}