using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startGame : MonoBehaviour 
{
    public Transform door;
    public Transform doorTwo;
    public static bool timeIsUp;
    public AudioSource music;
    private void Start()
    {
        timeIsUp = false;
    }
    private void Update()
    {
        if(EnemyTrigger.TheyGotYou)
        {
            music.Stop();
            Transparancy.startGame = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            music.Play();
            Debug.Log("Game started...");
            door.position = new Vector3(0, -10, 0);
            doorTwo.position = new Vector3(0, -10, 0);
            Transparancy.startGame = true;
            intro.introOver = true;
        }
    }
}
