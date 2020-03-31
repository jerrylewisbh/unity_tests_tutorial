public interface IEquippable
{
    void Equip(Item item);
    Item ItemEquippedByType(ItemType type);
}