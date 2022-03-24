using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class intro : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI introText;
    [SerializeField] private TextMeshProUGUI pressAnyKey;
    int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        introText.enabled = true;
        pressAnyKey.enabled = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        count++;
        if(count >= 500)
        {
            pressAnyKey.enabled = true;
            startGame.timeIsUp = true;
        }
        //if (Input.anyKey)
        //{
        //    introText.enabled = false;
        //}
    }
}
