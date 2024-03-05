using Brave.Entities.Game.Items;

namespace Brave.Entities.Classes;

class Warrior : Player
{
    private double _baseHealth = 110;
    private double _baseDamage = 5; // Player starts without weapon
    private double _baseStamina = 100;
    private Item _initialWeapon = new BasicSword();

    public Warrior(string name) : base(name)
    {
        MaxHealth = _baseHealth;
        MaxStamina = _baseStamina;

        Health = MaxHealth;
        Stamina = MaxStamina;
        Damage = _baseDamage;
        Inventory.Add(_initialWeapon);
        EquipItem(_initialWeapon.Name);
    }

    public override void Attack(Player target)
    {
        target.Health -= Damage;
    }
    public override void Dodge()
    {

    }
}