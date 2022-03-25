using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenWhenGameStarts : MonoBehaviour
{
    float count = 0;
    bool isOpened = false;
    public Transform door;
    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (count <= 10 && !isOpened)
        {
            count += 0.1f;
        }
        else
        {
            isOpened = true;
            count = 0;
        }
        Debug.Log(count);
        door.rotation = Quaternion.Euler(0, 0, 90*Time.deltaTime);
    }
}
