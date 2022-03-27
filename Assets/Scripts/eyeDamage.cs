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
    public AudioSource GameOverSound;
    int count = 0;
    void Start()
    {
        //gameOver.enabled = false;
        //healthText.enabled = true;
        gameOver.text = GameOverManager.GetInstance().GameOver;
        healthText.text = "---";
    }

    // Update is called once per frame
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
            GameOverSound.Play();
            //Debug.Log("test");
        }
    }
}
