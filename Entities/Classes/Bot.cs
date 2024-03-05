using Brave.Entities.Game.Items;

namespace Brave.Entities.Classes;

class Bot : Player
{
    private Item _initialWeapon = new BasicSword();
    private Random _botRng = new Random();
    public Bot(string name, Player basedOnPlayer) : base(name)
    {
        MaxHealth = _botRng.Next((int)basedOnPlayer.Health - 20, (int)basedOnPlayer.Health + 5);
        MaxStamina = _botRng.Next((int)basedOnPlayer.Stamina - 20, (int)basedOnPlayer.Stamina + 10);
        Damage = _botRng.Next((int)basedOnPlayer.Damage - 5, (int)basedOnPlayer.Damage + 5); ;

        Health = MaxHealth;
        Stamina = MaxStamina;
        Inventory.Add(_initialWeapon);
    }

    public override void Attack(Player target)
    {
        target.Health -= Damage;
    }
    public override void Dodge()
    {

    }
}