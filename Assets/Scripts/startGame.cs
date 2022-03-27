using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startGame : MonoBehaviour 
{
    public Transform door;
    public Transform doorTwo;
    public static bool timeIsUp=false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            
            Debug.Log("Game started...");
            door.position = new Vector3(0, -10, 0);
            doorTwo.position = new Vector3(0, -10, 0);
            Transparancy.startGame = true;
        }
    }
}
