using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    private static GameOverManager instance;
    public static GameOverManager GetInstance() { return instance; }
    string GameOverText = "";    
    void Start()
    {
        instance = this;
        string GameOverText = "";
    }    
    public void GameOverInput(string GameIsOver)
    {
        GameOverText = GameIsOver;
    }
    public string GameOver
    {
        get { return GameOverText; }
    }
}
