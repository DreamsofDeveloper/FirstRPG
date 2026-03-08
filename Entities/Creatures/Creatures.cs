using System;
using FirstRPG.Entities.Items;

public abstract class Creatures

{
    protected string Name;
    protected double Hp;
    private double ReHp = 50;
    public bool IsDead = false;
    Floor floor;

   


   
    public Creatures(string name, double hp, Floor floor)
    {
        Name = name;
        Hp = hp;
        this.floor = floor;
       
    }

    public void TakeDamage(double amount)
    {
        Hp -= amount;
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
}