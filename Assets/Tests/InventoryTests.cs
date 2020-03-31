using System.Collections;
using System.Collections.Generic;
using NSubstitute;
using NUnit.Framework;
using UnityEngine;

public class InventoryTests 
{
   
   //https://github.com/nsubstitute/NSubstitute
   [Test]
   public void Equip_Item_by_Type_Does_Not_Change_If_Equip_Again()
   {
      
      //ARRANGE
      IEquippable inventory = Substitute.For<IEquippable>();
      Item item1 = new Item(ItemType.Gun);
      Item item2 = new Item(ItemType.Gun);

      inventory.ItemEquippedByType(ItemType.Gun).Returns(item1);
      
      
      //ACT
      inventory.Equip(item1);
      inventory.Equip(item2);
      
      //ASSERT
      Assert.AreEqual(item1, inventory.ItemEquippedByType(ItemType.Gun));

   }
}
