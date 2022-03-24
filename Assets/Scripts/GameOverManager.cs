using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    private static GameOverManager instance;
    public static GameOverManager GetInstance() { return instance; }
    string GameOverText = "";
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        string GameOverText = "";
    }
    // Update is called once per frame
    void Update()
    {

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
