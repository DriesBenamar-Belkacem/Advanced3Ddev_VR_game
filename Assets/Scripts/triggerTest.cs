using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerTest : MonoBehaviour
{
    public AudioSource waterSound;    
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
