using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class eyeDamage : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI healthText;
    [SerializeField] private TextMeshProUGUI gameOver;
    
    int count = 0;
    void Start()
    {
        gameOver.text = GameOverManager.GetInstance().GameOver;
        healthText.text = "";
    }

    void Update()
    {
        if (Transparancy.startGame)
        {
            healthText.enabled = true;
            healthText.text = "eye damage is " + Mathf.Round(Transparancy.count / 5) + "%";
            Debug.Log("testing letters");
        }
        if(Transparancy.triggGameOver||EnemyTrigger.TheyGotYou)
        {
            healthText.enabled = false;
            GameOverManager.GetInstance().GameOverInput("Game over");
            gameOver.text = GameOverManager.GetInstance().GameOver;            
        }
    }
}
