using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit;


public class intro : MonoBehaviour//ergens bool toevoegen voor einde intro
{
    [SerializeField] private TextMeshProUGUI introText;
    [SerializeField] private TextMeshProUGUI pressAnyKey;
    int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        introText.enabled = true;
        pressAnyKey.enabled = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        count++;
        if(count >= 500)//switch loop for intro
        {
            pressAnyKey.enabled = true;
            startGame.timeIsUp = true;
            introText.text = "Also, watch out for the enemies are somewhere inside the school and dont care if you're injured.";
        }
        
        //if (Input.anyKey)
        //{
        //    introText.enabled = false;
        //}
    }
}
