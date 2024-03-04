using Brave.Entities.Game.Items;

namespace Brave.Entities.Classes;

abstract class Player
{
    public string Name { get; set; }
    public double Damage { get; set; }
    public double Health { get; set; }
    public double Stamina { get; set; }
    public List<Item> Inventory { get; set; } = new List<Item>();
    public List<Item> Equipped { get; set; } = new List<Item>();

    public Player(string name, double damage, double health, double stamina)
    {
        Name = name;
        Damage = damage;
        Health = health;
        Stamina = stamina;
    }

    public abstract void Attack();
    public abstract void Dodge();
    public abstract void EquipItem();
    public abstract void UnequipedItem();
    public abstract void Loot();
}