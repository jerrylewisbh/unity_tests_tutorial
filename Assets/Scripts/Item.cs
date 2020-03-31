public class Item
{
    public ItemType itemType { get; set; }

    public Item(ItemType itemType)
    {
        this.itemType = itemType;
    }
}