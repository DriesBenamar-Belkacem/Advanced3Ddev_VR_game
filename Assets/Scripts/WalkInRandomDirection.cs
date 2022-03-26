using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WalkInRandomDirection : MonoBehaviour
{
    public float radius;
    public float timer;

    private Transform target;
    private NavMeshAgent agent;
    public Transform player;
    private float currentTimer;
    private bool isClose = false;

    private void Start()
    {
        
    }
    private void OnEnable()
    {
        agent = GetComponent<NavMeshAgent>();
        currentTimer = timer;
    }
    private void Update()
    {
        currentTimer += Time.deltaTime;

        if (currentTimer >= timer && !isClose &&Transparancy.startGame)
        {
            Vector3 newPosition = RandomNavSphere(transform.position, radius, -1);
            agent.SetDestination(newPosition);
            currentTimer = 0;
        }
        if(!Transparancy.startGame)
        {

        }
        if(isClose && Transparancy.startGame)
        {
            agent.SetDestination(player.position);
        }
    }
    public static Vector3 RandomNavSphere(Vector3 origin, float distance, int layerMask)
    {
        Vector3 randomDirection = Random.insideUnitSphere * distance;
        randomDirection += origin;

        NavMeshHit navHit;
        NavMesh.SamplePosition(randomDirection, out navHit, distance, layerMask);
        return navHit.position;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            isClose = true;
            Debug.Log("You're close watchout");
        }

    }
}
