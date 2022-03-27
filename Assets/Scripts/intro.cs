using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit;


public class intro : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI introText;
    [SerializeField] private TextMeshProUGUI pressAnyKey;
    [SerializeField] private TextMeshProUGUI WaterFountain;
    public GameObject arrow;
    public GameObject lunchLadyIntro;
    public GameObject secretaryIntro;
    public GameObject docIntro;
    int count = 0;
    public static bool introOver;
    void Start()
    {
        introOver = false;
        docIntro.SetActive(false);
        arrow.SetActive(false);
        secretaryIntro.SetActive(false);
        lunchLadyIntro.SetActive(false);
        introText.enabled = true;
        pressAnyKey.enabled = true;
        WaterFountain.enabled = false;
    }
    void FixedUpdate()
    {
        count++;
        if(count >= 500)
        {
            docIntro.SetActive(true);
            introText.text = "Quick go to the medic so he can help you restore your vision!";
        }
        if (count >= 1000)
        {
            docIntro.SetActive(false);
            pressAnyKey.enabled = true;
            startGame.timeIsUp = true;
            lunchLadyIntro.SetActive(true);
            secretaryIntro.SetActive(true);
            introText.text = "Also, watch out for the enemies are somewhere inside the school and dont care if you're injured.";
        }
        if (count >= 1500)
        {
            WaterFountain.enabled = true;
            arrow.SetActive(true);
        }
        if(introOver)
        {
            docIntro.SetActive(false);
            arrow.SetActive(false);
            secretaryIntro.SetActive(false);
            lunchLadyIntro.SetActive(false);
            introText.enabled = false;
            pressAnyKey.enabled = false;
            WaterFountain.enabled = false;
        }
    }
}
