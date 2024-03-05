using System.Text;
using Brave.Entities.Enums;

namespace Brave.Entities.Game.Items;

abstract class Item
{
    public string Name { get; set; }
    public ItemType Type { get; set; }
    public double Durability { get; set; }
    public double Rarity { get; set; }
    public bool IsEquipped { get; set; }
    public Buffs Buff { get; set; }

    public Item() { }

    public override string ToString()
    {
        StringBuilder itemData = new StringBuilder();
        itemData.Append("Item Name: ");
        itemData.Append(Name);
        itemData.Append(", Type: ");
        itemData.Append(Type.ToString());
        itemData.Append(", Durability: ");
        itemData.Append(Durability.ToString());
        itemData.Append(", Rarity: ");
        itemData.Append(Rarity.ToString());


        return itemData.ToString();
    }
}