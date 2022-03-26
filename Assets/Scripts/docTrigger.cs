using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class docTrigger : MonoBehaviour
{
    private Animation doc;
    private bool isIdle;
   
    void Start()
    {
        doc = gameObject.GetComponent<Animation>();
        isIdle = true;
    }

    void Update()
    {
        //if(isIdle)
        //{
            doc.Play("Idle");
        //}
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Transparancy.startGame = false;
            Transparancy.trigg = true;
            //isIdle = false;
            Debug.Log("arrived at ehbo");
            doc.Play("Hello");
            
        }
        //else
        //{
        //    isIdle = true;
        //}

    }
}

