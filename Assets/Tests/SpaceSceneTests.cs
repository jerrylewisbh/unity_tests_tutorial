using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class SpaceSceneTests
    {
        // A Test behaves as an ordinary method
        [Test]
        public void SpaceScene_OpenScene_Has_Only_One_Light()
        {
            //ARRANGE
            EditorSceneManager.OpenScene("Assets/Scenes/Space.unity");

            //ACT
            Light[] lights = GameObject.FindObjectsOfType<Light>();

            //ASSERT
            Assert.AreEqual(1, lights.Length);

        }

       
    }
}
