using System.Diagnostics.Tracing;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;
using FirstRPG.Entities.Items;

public class CombatSystem
{
    public async Task Combat(Creatures attacker, Creatures target)
    {

        if (attacker.IsDead)
        {
            Console.WriteLine($"{attacker.Name} ölü, saldırı olamaz!");
        }
        double attackerDamage = attacker.CalculateAttackPower;
        double targetDamage = target.CalculateAttackPower;
        double durabilityLoss = 0;

        if (attacker.EquippedWeapon != null)
        {
        if (target.Shield != null)
    {
            durabilityLoss += MaterialInteraction.GetCombatDurabilityLossForWeapon(
            attacker.EquippedWeapon.BaseMaterial,
            target.Shield.BaseMaterial); 
        }

        if (target.BodyArmor != null)
        {
            durabilityLoss += MaterialInteraction.GetCombatDurabilityLossForWeapon(
            attacker.EquippedWeapon.BaseMaterial,
            target.BodyArmor.BaseMaterial);
        }

     else durabilityLoss += MaterialInteraction.GetCombatDurabilityLossForWeapon(attacker.EquippedWeapon.BaseMaterial, BaseMaterial.none);
}

        while (!attacker.IsDead && !target.IsDead)
        {
            target.TakeDamage(attackerDamage);
            if(attacker.EquippedWeapon != null )
            {attacker.EquippedWeapon!.ReduceDurability(durabilityLoss); //silahın dayanıklığını azaltma

            Console.WriteLine($"{attacker.EquippedWeapon!.Name} Dayanıklık: {attacker.EquippedWeapon.Durability}");
            }
            if (target.IsDead) break;

            await Task.Delay(500);

            attacker.TakeDamage(targetDamage);
            if (attacker.IsDead) break;

            await Task.Delay(500);
        }
    }
}