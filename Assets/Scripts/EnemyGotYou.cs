using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGotYou : MonoBehaviour
{
    public AudioSource GameOverSound;
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Enemy")
        {
        GameOverSound.Play();
        }
    }
}
