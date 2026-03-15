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

        while (!attacker.IsDead && !target.IsDead)
        {
            target.TakeDamage(attackerDamage);
            if (target.IsDead) break;

            await Task.Delay(500);

            attacker.TakeDamage(targetDamage);
            if (attacker.IsDead) break;

            await Task.Delay(500);
        }
    }
}