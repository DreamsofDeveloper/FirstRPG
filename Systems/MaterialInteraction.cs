

using FirstRPG.Entities.Items;

public static class MaterialInteraction
{




    public static double GetCombatDurabilityLossForWeapon(BaseMaterial weaponMaterial, BaseMaterial armorMaterial)
    {


        /*
        Weapon and Armor Base Materials
        - Wood    - only weapon
        - Stone   - only weapon
        - leather - only armor
        - Copper
        - Steel
        - Silver
        - Iron
        - Gold
        - Diamond
        - Mithril
        - Adamantite
        */
    switch (weaponMaterial)
    {
        case BaseMaterial.Wood:
            if (armorMaterial == BaseMaterial.Leather) return 0.8;
            if (armorMaterial == BaseMaterial.Copper) return 1.2;
            if (armorMaterial == BaseMaterial.Iron || armorMaterial == BaseMaterial.Steel || armorMaterial == BaseMaterial.Silver) return 2.0;
            if (armorMaterial == BaseMaterial.Gold || armorMaterial == BaseMaterial.Diamond) return 3.0;
            if (armorMaterial == BaseMaterial.Mithril || armorMaterial == BaseMaterial.Adamantite) return 4.2;
            break;

        case BaseMaterial.Stone:
            if (armorMaterial == BaseMaterial.Leather) return 0.6;
            if (armorMaterial == BaseMaterial.Copper) return 1.0;
            if (armorMaterial == BaseMaterial.Iron || armorMaterial == BaseMaterial.Steel || armorMaterial == BaseMaterial.Silver) return 1.7;
            if (armorMaterial == BaseMaterial.Gold || armorMaterial == BaseMaterial.Diamond) return 2.6;
            if (armorMaterial == BaseMaterial.Mithril || armorMaterial == BaseMaterial.Adamantite) return 3.8;
            break;

        case BaseMaterial.Copper:
            if (armorMaterial == BaseMaterial.Leather) return 0.4;
            if (armorMaterial == BaseMaterial.Copper) return 0.8;
            if (armorMaterial == BaseMaterial.Iron || armorMaterial == BaseMaterial.Steel || armorMaterial == BaseMaterial.Silver) return 1.4;
            if (armorMaterial == BaseMaterial.Gold || armorMaterial == BaseMaterial.Diamond) return 2.1;
            if (armorMaterial == BaseMaterial.Mithril || armorMaterial == BaseMaterial.Adamantite) return 3.2;
            break;

        case BaseMaterial.Iron:
            if (armorMaterial == BaseMaterial.Leather) return 0.3;
            if (armorMaterial == BaseMaterial.Copper) return 0.6;
            if (armorMaterial == BaseMaterial.Iron || armorMaterial == BaseMaterial.Steel || armorMaterial == BaseMaterial.Silver) return 1.1;
            if (armorMaterial == BaseMaterial.Gold || armorMaterial == BaseMaterial.Diamond) return 1.7;
            if (armorMaterial == BaseMaterial.Mithril || armorMaterial == BaseMaterial.Adamantite) return 2.7;
            break;

        case BaseMaterial.Steel:
            if (armorMaterial == BaseMaterial.Leather) return 0.2;
            if (armorMaterial == BaseMaterial.Copper) return 0.5;
            if (armorMaterial == BaseMaterial.Iron || armorMaterial == BaseMaterial.Steel || armorMaterial == BaseMaterial.Silver) return 0.9;
            if (armorMaterial == BaseMaterial.Gold || armorMaterial == BaseMaterial.Diamond) return 1.5;
            if (armorMaterial == BaseMaterial.Mithril || armorMaterial == BaseMaterial.Adamantite) return 2.3;
            break;

        case BaseMaterial.Silver:
            if (armorMaterial == BaseMaterial.Leather) return 0.25;
            if (armorMaterial == BaseMaterial.Copper) return 0.55;
            if (armorMaterial == BaseMaterial.Iron || armorMaterial == BaseMaterial.Steel || armorMaterial == BaseMaterial.Silver) return 1.0;
            if (armorMaterial == BaseMaterial.Gold || armorMaterial == BaseMaterial.Diamond) return 1.6;
            if (armorMaterial == BaseMaterial.Mithril || armorMaterial == BaseMaterial.Adamantite) return 2.4;
            break;

        case BaseMaterial.Gold:
            if (armorMaterial == BaseMaterial.Leather) return 0.35;
            if (armorMaterial == BaseMaterial.Copper) return 0.7;
            if (armorMaterial == BaseMaterial.Iron || armorMaterial == BaseMaterial.Steel || armorMaterial == BaseMaterial.Silver) return 1.2;
            if (armorMaterial == BaseMaterial.Gold || armorMaterial == BaseMaterial.Diamond) return 1.8;
            if (armorMaterial == BaseMaterial.Mithril || armorMaterial == BaseMaterial.Adamantite) return 2.8;
            break;

        case BaseMaterial.Diamond:
            if (armorMaterial == BaseMaterial.Leather) return 0.1;
            if (armorMaterial == BaseMaterial.Copper) return 0.3;
            if (armorMaterial == BaseMaterial.Iron || armorMaterial == BaseMaterial.Steel || armorMaterial == BaseMaterial.Silver) return 0.7;
            if (armorMaterial == BaseMaterial.Gold || armorMaterial == BaseMaterial.Diamond) return 1.2;
            if (armorMaterial == BaseMaterial.Mithril || armorMaterial == BaseMaterial.Adamantite) return 1.9;
            break;

        case BaseMaterial.Mithril:
            if (armorMaterial == BaseMaterial.Leather) return 0.06;
            if (armorMaterial == BaseMaterial.Copper) return 0.2;
            if (armorMaterial == BaseMaterial.Iron || armorMaterial == BaseMaterial.Steel || armorMaterial == BaseMaterial.Silver) return 0.5;
            if (armorMaterial == BaseMaterial.Gold || armorMaterial == BaseMaterial.Diamond) return 0.9;
            if (armorMaterial == BaseMaterial.Mithril || armorMaterial == BaseMaterial.Adamantite) return 1.5;
            break;

        case BaseMaterial.Adamantite:
            if (armorMaterial == BaseMaterial.Leather) return 0.03;
            if (armorMaterial == BaseMaterial.Copper) return 0.1;
            if (armorMaterial == BaseMaterial.Iron || armorMaterial == BaseMaterial.Steel || armorMaterial == BaseMaterial.Silver) return 0.35;
            if (armorMaterial == BaseMaterial.Gold || armorMaterial == BaseMaterial.Diamond) return 0.7;
            if (armorMaterial == BaseMaterial.Mithril || armorMaterial == BaseMaterial.Adamantite) return 1.1;
            break;
    }
    

    return 0.2;
}


public static double GetCombatDurabilityLossForArmor(BaseMaterial armorMaterial, BaseMaterial weaponMaterial)
{
    switch (armorMaterial)
    {
        case BaseMaterial.Leather:
            if (weaponMaterial == BaseMaterial.Wood || weaponMaterial == BaseMaterial.Stone) return 0.6;
            if (weaponMaterial == BaseMaterial.Copper) return 1.0;
            if (weaponMaterial == BaseMaterial.Iron || weaponMaterial == BaseMaterial.Steel || weaponMaterial == BaseMaterial.Silver) return 1.8;
            if (weaponMaterial == BaseMaterial.Gold || weaponMaterial == BaseMaterial.Diamond) return 2.8;
            if (weaponMaterial == BaseMaterial.Mithril || weaponMaterial == BaseMaterial.Adamantite) return 4.0;
            break;

        case BaseMaterial.Copper:
            if (weaponMaterial == BaseMaterial.Wood) return 0.4;
            if (weaponMaterial == BaseMaterial.Stone) return 0.7;
            if (weaponMaterial == BaseMaterial.Copper) return 0.9;
            if (weaponMaterial == BaseMaterial.Iron || weaponMaterial == BaseMaterial.Steel || weaponMaterial == BaseMaterial.Silver) return 1.6;
            if (weaponMaterial == BaseMaterial.Gold || weaponMaterial == BaseMaterial.Diamond) return 2.6;
            if (weaponMaterial == BaseMaterial.Mithril || weaponMaterial == BaseMaterial.Adamantite) return 3.8;
            break;

        case BaseMaterial.Iron:
            if (weaponMaterial == BaseMaterial.Wood) return 0.2;
            if (weaponMaterial == BaseMaterial.Stone) return 0.5;
            if (weaponMaterial == BaseMaterial.Copper) return 0.8;
            if (weaponMaterial == BaseMaterial.Iron || weaponMaterial == BaseMaterial.Steel || weaponMaterial == BaseMaterial.Silver) return 1.2;
            if (weaponMaterial == BaseMaterial.Gold || weaponMaterial == BaseMaterial.Diamond) return 2.0;
            if (weaponMaterial == BaseMaterial.Mithril || weaponMaterial == BaseMaterial.Adamantite) return 3.4;
            break;

        case BaseMaterial.Steel:
            if (weaponMaterial == BaseMaterial.Wood) return 0.1;
            if (weaponMaterial == BaseMaterial.Stone) return 0.4;
            if (weaponMaterial == BaseMaterial.Copper) return 0.7;
            if (weaponMaterial == BaseMaterial.Iron || weaponMaterial == BaseMaterial.Steel || weaponMaterial == BaseMaterial.Silver) return 1.0;
            if (weaponMaterial == BaseMaterial.Gold || weaponMaterial == BaseMaterial.Diamond) return 1.8;
            if (weaponMaterial == BaseMaterial.Mithril || weaponMaterial == BaseMaterial.Adamantite) return 3.0;
            break;

        case BaseMaterial.Silver:
            if (weaponMaterial == BaseMaterial.Wood) return 0.2;
            if (weaponMaterial == BaseMaterial.Stone) return 0.5;
            if (weaponMaterial == BaseMaterial.Copper) return 0.8;
            if (weaponMaterial == BaseMaterial.Iron || weaponMaterial == BaseMaterial.Steel || weaponMaterial == BaseMaterial.Silver) return 1.3;
            if (weaponMaterial == BaseMaterial.Gold || weaponMaterial == BaseMaterial.Diamond) return 2.1;
            if (weaponMaterial == BaseMaterial.Mithril || weaponMaterial == BaseMaterial.Adamantite) return 3.5;
            break;

        case BaseMaterial.Gold:
            if (weaponMaterial == BaseMaterial.Wood) return 0.3;
            if (weaponMaterial == BaseMaterial.Stone) return 0.7;
            if (weaponMaterial == BaseMaterial.Copper) return 1.0;
            if (weaponMaterial == BaseMaterial.Iron || weaponMaterial == BaseMaterial.Steel || weaponMaterial == BaseMaterial.Silver) return 1.7;
            if (weaponMaterial == BaseMaterial.Gold || weaponMaterial == BaseMaterial.Diamond) return 2.4;
            if (weaponMaterial == BaseMaterial.Mithril || weaponMaterial == BaseMaterial.Adamantite) return 3.7;
            break;

        case BaseMaterial.Diamond:
            if (weaponMaterial == BaseMaterial.Wood) return 0.05;
            if (weaponMaterial == BaseMaterial.Stone) return 0.2;
            if (weaponMaterial == BaseMaterial.Copper) return 0.4;
            if (weaponMaterial == BaseMaterial.Iron || weaponMaterial == BaseMaterial.Steel || weaponMaterial == BaseMaterial.Silver) return 0.9;
            if (weaponMaterial == BaseMaterial.Gold || weaponMaterial == BaseMaterial.Diamond) return 1.4;
            if (weaponMaterial == BaseMaterial.Mithril || weaponMaterial == BaseMaterial.Adamantite) return 2.4;
            break;

        case BaseMaterial.Mithril:
            if (weaponMaterial == BaseMaterial.Wood) return 0.02;
            if (weaponMaterial == BaseMaterial.Stone) return 0.1;
            if (weaponMaterial == BaseMaterial.Copper) return 0.3;
            if (weaponMaterial == BaseMaterial.Iron || weaponMaterial == BaseMaterial.Steel || weaponMaterial == BaseMaterial.Silver) return 0.7;
            if (weaponMaterial == BaseMaterial.Gold || weaponMaterial == BaseMaterial.Diamond) return 1.1;
            if (weaponMaterial == BaseMaterial.Mithril || weaponMaterial == BaseMaterial.Adamantite) return 1.8;
            break;

        case BaseMaterial.Adamantite:
            if (weaponMaterial == BaseMaterial.Wood) return 0.01;
            if (weaponMaterial == BaseMaterial.Stone) return 0.05;
            if (weaponMaterial == BaseMaterial.Copper) return 0.15;
            if (weaponMaterial == BaseMaterial.Iron || weaponMaterial == BaseMaterial.Steel || weaponMaterial == BaseMaterial.Silver) return 0.5;
            if (weaponMaterial == BaseMaterial.Gold || weaponMaterial == BaseMaterial.Diamond) return 0.9;
            if (weaponMaterial == BaseMaterial.Mithril || weaponMaterial == BaseMaterial.Adamantite) return 1.4;
            break;
    }

    return 0.2;
}

/*
    public static double GetMiningDurabilityLoss(BaseMaterial toolMaterial, BaseMaterial targetMaterial)
    {
        // kurallar
    }

    public static double GetMiningTime(BaseMaterial toolMaterial, BaseMaterial targetMaterial)
    {
        // kurallar
    }
    */
}