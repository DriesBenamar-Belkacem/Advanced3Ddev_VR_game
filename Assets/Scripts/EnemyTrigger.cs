using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTrigger : MonoBehaviour
{
    [SerializeField] private Material myMaterialEnemy;
    public Color color;
    public static bool TheyGotYou;
    private void Start()
    {
        TheyGotYou = false;
        color = myMaterialEnemy.color;
        myMaterialEnemy.color = color;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            TheyGotYou = true;
            Debug.Log("Game Over next time avoid the enemies");
            color.a = 0;
            myMaterialEnemy.color = color;
        }
    }
}
