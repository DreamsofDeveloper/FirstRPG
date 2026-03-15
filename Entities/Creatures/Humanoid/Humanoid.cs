using FirstRPG.Entities.Items;

public abstract class Humanoid : Creatures
{
    protected Humanoid(
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
        bool isdead)
        : base(
            name,
            hp,
            floor,
            container,
            headarmor,
            bodyarmor,
            handarmor,
            legarmor,
            feetarmor,
            shield,
            weapon,
            attackpower,
            isdead)
    {
    }
}