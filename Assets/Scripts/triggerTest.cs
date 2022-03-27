using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerTest : MonoBehaviour
{
    //public bool isClose = false;
    //public bool enemyCollision = false;
    // Start is called before the first frame update
    public AudioSource waterSound;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            waterSound.Play();
            Transparancy.trigg = true;
            Debug.Log("zone entered");
        }

    }
}
