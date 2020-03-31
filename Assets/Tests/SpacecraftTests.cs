using System.Collections;
using System.Collections.Generic;
using NSubstitute;
using NUnit.Framework;
using UnityEngine;


public class SpacecraftTests 
{
   [Test]
   public void ApplyDamage_100Damage_50percent_attenuation_total_damage_is_50()
   {
      //ARRANGE
      Spacecraft spacecraft = new Spacecraft();
      spacecraft.Health = 100;

      //ACT
      spacecraft.ApplyDamage(100, .5f);
      
      //ASSERT
      Assert.AreEqual(50, spacecraft.Health);

   }
   
   [Test]
   public void ApplyDamage_100Damage_20percent_attenuation_total_damage_is_80()
   {
      //ARRANGE
      Spacecraft spacecraft = new Spacecraft();
      spacecraft.Health = 100;

      //ACT
      spacecraft.ApplyDamage(100, .2f);
      
      //ASSERT
      Assert.AreEqual(80, spacecraft.Health);

   }
   
}
