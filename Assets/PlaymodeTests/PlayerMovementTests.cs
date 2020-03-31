using System.Collections;
using System.Collections.Generic;
using NSubstitute;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class PlayerMovementTests
    {
       
        [UnityTest]
        public IEnumerator Player_Vertical_Input_Moves_Only_Forward()
        {
            GameObject playerObject = new GameObject("Player");
            Spacecraft player = playerObject.AddComponent<Spacecraft>();

            GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            sphere.transform.parent = player.transform;
            sphere.transform.localPosition = Vector3.zero;

            Spacecraft.IInput input = Substitute.For<Spacecraft.IInput>();
            input.Vertical.Returns(1f);

            player.playerInput = input;
            yield return new WaitForSeconds(1f);
            
            Assert.Greater(player.transform.position.z, 0f);
            Assert.IsTrue(player.transform.position.x == 0f);
            Assert.IsTrue(player.transform.position.y == 0f);
            
        }
    }
}
