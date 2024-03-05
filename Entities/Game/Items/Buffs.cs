namespace Brave.Entities.Game.Items;

class Buffs
{
    public double HealthBuff { get; set; }
    public double StaminaBuff { get; set; }
    public double DamageBuff { get; set; }

    public Buffs(double healthBuff, double staminaBuff, double damageBuff)
    {
        HealthBuff = healthBuff;
        StaminaBuff = staminaBuff;
        DamageBuff = damageBuff;
    }
}