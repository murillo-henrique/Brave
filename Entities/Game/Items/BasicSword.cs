using Brave.Entities.Enums;

namespace Brave.Entities.Game.Items;

class BasicSword : Item
{
    public BasicSword()
    {
        Name = "Basic Sword";
        Type = ItemType.Weapon;
        Durability = 250;
        Rarity = 1;
        Buff = new Buffs(0, 0, 15);
        IsEquipped = false;
    }
}