using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startGame : MonoBehaviour //add mesh rendere activation
{
    public Transform door;
    public Transform doorTwo;
    //public Renderer cubeButton;
    public static bool timeIsUp=false;
    // Start is called before the first frame update
    void Start()
    {
        //door.position = new Vector3(0, 0, 0);
        //cubeButton.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //if(timeIsUp)
        //{
        //    cubeButton.enabled = true;
        //}
    }
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
