using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class docTrigger : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("arrived at ehbo");
        }

    }
}

