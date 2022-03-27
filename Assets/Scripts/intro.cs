using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit;


public class intro : MonoBehaviour//ergens bool toevoegen voor einde intro
{
    [SerializeField] private TextMeshProUGUI introText;
    [SerializeField] private TextMeshProUGUI pressAnyKey;
    [SerializeField] private TextMeshProUGUI WaterFountain;
    public GameObject arrow;
    public GameObject lunchLadyIntro;
    public GameObject secretaryIntro;
    public GameObject docIntro;
    int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        docIntro.SetActive(false);
        arrow.SetActive(false);
        secretaryIntro.SetActive(false);
        lunchLadyIntro.SetActive(false);
        introText.enabled = true;
        pressAnyKey.enabled = true;
        WaterFountain.enabled = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        count++;
        if(count >= 500)//switch loop for intro
        {
            docIntro.SetActive(true);
            //startGame.timeIsUp = true;
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
        //if(count>=2000)
        //{

        //}
        //if (Input.anyKey)
        //{
        //    introText.enabled = false;
        //}
    }
}
