using System.Collections.Generic;

public class Inventory : IEquippable
{
    private Dictionary<ItemType, Item> equippedItems;

    public Inventory()
    {
        equippedItems = new Dictionary<ItemType, Item>();
    }

    public void Equip(Item item)
    {
        if (!equippedItems.ContainsKey(item.itemType))
        {
            equippedItems.Add(item.itemType, item);
        }
    }

    public Item ItemEquippedByType(ItemType type)
    {
        if (equippedItems.ContainsKey(type))
            return equippedItems[type];
        else return null;
    }
}