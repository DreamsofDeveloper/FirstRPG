using System;
using FirstRPG.Entities.Items;

public abstract class Creatures
{
    public string Name { get; }
    public double Hp { get; set; }
public double TotalShieldPower
{
    get
    {
        double total = 0;

        if (HeadArmor != null) total += HeadArmor.Protection;
        if (BodyArmor != null) total += BodyArmor.Protection;
        if (HandArmor != null) total += HandArmor.Protection;
        if (LegArmor != null) total += LegArmor.Protection;
        if (FeetArmor != null) total += FeetArmor.Protection;
        if (Shield != null) total += Shield.Protection;

        return total;
    }
}

public double CurrentShieldPower { get; protected set; }

    private double ReHp = Hp;
    public double AttackPower { get; set; }
    public Container Container { get; protected set; }
    public bool IsDead { get; set; }

    // Body Parts
    public Armor? HeadArmor { get; set; }
    public Armor? BodyArmor { get; set; }
    public Armor? HandArmor { get; set; }
    public Armor? LegArmor { get; set; }
    public Armor? FeetArmor { get; set; }
    public Armor? Shield { get; set; }
    public Weapon? EquippedWeapon { get; set; }

    public Floor Floor { get; protected set; }

    private List<Armor> Armorequipments = new List<Armor>();

    public Creatures(
        string name,
        double hp,
        Floor floor,
        Container container,
        Armor? headarmor,
        Armor? bodyarmor,
        Armor? handarmor,
        Armor? legarmor,
        Armor? feetarmor,
        Armor? shield,
        Weapon? weapon,
        double attackpower,
        bool isdead
        )
    {
        Name = name;
        Hp = hp;
        Floor = floor;
        Container = container;
        HeadArmor = headarmor;
        BodyArmor = bodyarmor;
        HandArmor = handarmor;
        LegArmor = legarmor;
        FeetArmor = feetarmor;
        Shield = shield;
        EquippedWeapon = weapon;
        AttackPower = attackpower;
        IsDead = isdead;
        


        CurrentShieldPower = TotalShieldPower;

    }
  public void TakeDamage(double amount)
{
    if (IsDead) return;

    double remainingDamage = amount;

    if (CurrentShieldPower > 0)
    {
        if (CurrentShieldPower >= remainingDamage)
        {
            CurrentShieldPower -= remainingDamage;
            remainingDamage = 0;
        }
        else
        {
            remainingDamage -= CurrentShieldPower;
            CurrentShieldPower = 0;
        }
    }

    if (remainingDamage > 0)
    {
        Hp -= remainingDamage;
    }

    if (Hp < 0)
        Hp = 0;

    Console.WriteLine($"{Name} {amount} hasar aldı. Kalan HP: {Hp}, Kalkan: {CurrentShieldPower}");

    if (Hp <= 0 && !IsDead)
    {
        Die();
    }
}

    public virtual void Die()
    {
        IsDead = true;
        Console.WriteLine($"{Name} öldü!");
    }

    public void Respawn()
    {
        if (IsDead)
        {
            Hp = ReHp;
            IsDead = false;
        }
    }

    public double CalculateAttackPower
    
    {
        get {

            double weaponDamage = EquippedWeapon?.Damage ?? 0;
        
        return AttackPower +  weaponDamage;
    }

    }


  

    public virtual List<Item> Loots()
    {
        return new List<Item>();
    }

 public void RefreshShieldFromEquipment()
{
    CurrentShieldPower = TotalShieldPower;
}

    

}