using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class eyeDamage : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private TextMeshProUGUI healthText;
    [SerializeField] private TextMeshProUGUI gameOver;
    int count = 0;
    void Start()
    {
        //gameOver.enabled = false;
        gameOver.text = GameOverManager.GetInstance().GameOver;
    }

    // Update is called once per frame
    void Update()
    {
        if(Mathf.Round(Transparancy.count / 5)%5==0)
        {
            healthText.text = "eye damage is " + Mathf.Round(Transparancy.count / 5) + "%";
        }
        else
        {
            healthText.text = "";
        }
        if(Transparancy.triggGameOver)
        {
            GameOverManager.GetInstance().GameOverInput("Game over");
            gameOver.text = GameOverManager.GetInstance().GameOver;
            Debug.Log("test");
        }
    }
}
