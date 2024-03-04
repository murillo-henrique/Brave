using Brave.Entities.Enums;

namespace Brave.Entities.Game.Items;

abstract class Item
{
    public string Name { get; set; }
    public ItemType Type { get; set; }

    public Item(string name, ItemType type)
    {
        Name = name;
        Type = type;
    }
}