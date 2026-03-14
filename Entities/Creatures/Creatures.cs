using System;
using FirstRPG.Entities.Items;

public abstract class Creatures

{
    public string Name{get;}
    public double Hp{get; set;}
    private double ReHp = 50;
    public double AttackPower;
    private Container Container;
    public bool IsDead = false;


    //Body Parts

    public Armor? HeadArmor { get; set; }
    public Armor? BodyArmor { get; set; }
    public Armor? HandArmor { get; set; }
    public Armor? LegArmor { get; set; }
    public Armor? FeetArmor { get; set; }
    public Armor? Shield { get; set; }
    public Weapon? EquippedWeapon { get; set; }
    Floor Floor;

   


   
    public Creatures(string name, double hp, Floor floor, Container container, Armor? headarmor, Armor? bodyarmor, Armor? handarmor, Armor? legarmor, Armor? feetarmor, Armor shield, Weapon weapon, double attackpower, bool isdead )
    {
        Name = name;
        Hp = hp;
        Floor     = floor;
        Container = container;
        HeadArmor = headarmor;
        BodyArmor = bodyarmor;
        HandArmor = handarmor;
        LegArmor  = legarmor;
        FeetArmor = feetarmor;
        Shield    = shield;
        EquippedWeapon = weapon;
        AttackPower = attackpower;
        IsDead = isdead;
       
    }

    public void TakeDamage(double amount)
        {
        if (IsDead) return;

         Hp -= amount;

            if (Hp < 0)
                 Hp = 0;

            Console.WriteLine($"{Name} {amount} hasar aldı. Kalan HP: {Hp}");

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

    public double CalculateAttacPower()
    {
       return AttackPower += EquippedWeapon!.Damage;
    }

   

    

}