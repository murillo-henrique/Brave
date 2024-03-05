using Brave.Entities.Game.Items;

namespace Brave.Entities.Classes;

abstract class Player
{
    public string Name { get; set; }
    public double Damage { get; set; }
    public double Health { get; set; }
    public double MaxHealth { get; set; }
    public double Stamina { get; set; }
    public double MaxStamina { get; set; }
    public List<Item> Inventory { get; set; } = new List<Item>();
    public List<Item> Equipped { get; set; } = new List<Item>();

    public Player(string name)
    {
        Name = name;
    }
    public Player(string name, double damage, double maxHealth, double maxStamina) // Prolly a constructor for npcs, idk.
    {
        Name = name;
        Damage = damage;
        MaxHealth = maxHealth;
        MaxStamina = maxStamina;

        Health = MaxHealth;
        Stamina = MaxStamina;
    }

    public abstract void Attack(Player target);
    public abstract void Dodge();

    public void EquipItem(string itemName)
    {
        foreach (Item item in Inventory)
        {
            if (item.Name.ToLower() == itemName.ToLower())
            {
                if (item.IsEquipped)
                {
                    Console.WriteLine("Item already equipped!");
                    return;
                }

                Equipped.Add(item);

                Health += item.Buff.HealthBuff;
                Stamina += item.Buff.StaminaBuff;
                Damage += item.Buff.DamageBuff;

                item.IsEquipped = true;
            }
            else
            {
                Console.WriteLine($"'{itemName}' has not been found in player's inventory.");
            }
        }
    }
    public void UnequipItem(string itemName)
    {
        foreach (Item item in Inventory)
        {
            if (item.Name.ToLower() == itemName.ToLower() && item.IsEquipped)
            {
                Equipped.Remove(item);

                Health -= item.Buff.HealthBuff;
                Stamina -= item.Buff.StaminaBuff;
                Damage -= item.Buff.DamageBuff;

                item.IsEquipped = false;
            }
            else
            {
                Console.WriteLine($"'{itemName}' has not been found in player's inventory.");
            }
        }
    }
    public void Loot(Item item)
    {
        Inventory.Add(item);
    }
    public void ShowInventory()
    {
        System.Console.WriteLine($"\n{Name} Inventory: ");
        foreach (Item item in Inventory)
        {
            Console.WriteLine(item);
        }
    }
    public override string ToString()
    {
        return $"Name: {Name}, Health: [{Health} / {MaxHealth}], Stamina: [{Stamina} / {MaxStamina}], Damage: {Damage}";
    }
}