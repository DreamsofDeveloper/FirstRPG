public interface IDurability
{
    void ReduceDurability(double amount);
    bool IsBroken();
    void UpgradeMaxDurability(int requiredLevel, double amount);
    void Repair();
}