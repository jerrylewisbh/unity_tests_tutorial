using System.Collections;
using System.Collections.Generic;
using NSubstitute;
using NUnit.Framework;
using UnityEngine;

public class GameManagerTests 
{
    [Test]
    public void GameOver_Calls_Player_OnGameOver_Successfully()
    {
        //ARRANGE
        IPlayer player = Substitute.For<IPlayer>();
        GameManager gameManager = new GameManager(player);
        
        //ACT
        gameManager.GameOver();
        
        //ASSERT
        player.Received().OnGameOver();
        
    }
}
