using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTrigger : MonoBehaviour
{
    public static bool TheyGotYou = false;
  
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            TheyGotYou = true;
            Debug.Log("Game Over next time avoid the enemies");
        }

    }
}
