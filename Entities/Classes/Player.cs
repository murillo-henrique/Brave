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

    public Player(string name)
    {
        Name = name;
    }
    public Player(string name, double damage, double health, double stamina) // Prolly a constructor for npcs, idk.
    {
        Name = name;
        Damage = damage;
        Health = health;
        Stamina = stamina;
    }

    public abstract void Attack();
    public abstract void Dodge();
    public void EquipItem()
    {

    }
    public void UnequipedItem()
    {

    }
    public void Loot()
    {

    }
}