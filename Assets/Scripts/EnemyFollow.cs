using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyFollow : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemy.SetDestination(player.position);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {           
            Debug.Log("waar is mijn geld?");
        }

    }
}
