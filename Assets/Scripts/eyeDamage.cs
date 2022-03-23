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
        gameOver.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "eye damage is " + Mathf.Round(Transparancy.count / 5) + "%";
        if(Transparancy.triggGameOver)
        {
            gameOver.text = "Game over";
            Debug.Log("test");
        }
    }
}