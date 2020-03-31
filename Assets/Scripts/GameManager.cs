using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager
{
    public IPlayer player;

    public GameManager(IPlayer player)
    {
        this.player = player;
    }

    public void GameOver()
    {
        player.OnGameOver();
    }
}