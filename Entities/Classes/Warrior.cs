using Brave.Entities.Game.Items;

namespace Brave.Entities.Classes;

class Warrior : Player
{
    private double _baseHealth = 110;
    private double _baseDamage = 25;
    private double _baseStamina = 100;

    public Warrior(string name) : base(name)
    {
        Health = _baseHealth;
        Damage = _baseDamage;
        Stamina = _baseStamina;
    }

    public override void Attack()
    {

    }
    public override void Dodge()
    {

    }

    public override string ToString()
    {
        return $"{Name}, {Health}, {Damage}, {Stamina}";
    }
}