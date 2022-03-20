using System.Collections;
using UnityEngine;

public class Transparancy : MonoBehaviour
{
    [SerializeField] private Material myMaterial;
    public static bool trigg;
    //public float timeStart;
    public Color color;
    int count = 0;
    private void Start()
    {
        color = myMaterial.color;
        color.a = 0;
        myMaterial.color = color;
    }
    private void FixedUpdate()
    {
        count++;
        //timeStart += Time.deltaTime;
        //Debug.Log(Mathf.Round(timeStart));
        color = myMaterial.color;
        if (count % 5 == 0)
        {
            color.a += 0.01f;
        }
        if (color.a >= 1.0f || trigg)
        {
            color.a = 0;
            trigg = false;
        }
        myMaterial.color = color;
        //Debug.Log(count);
    }

    //IEnumerator waitFS()
    //{
    //    yield return new WaitForSeconds(1);
    //}
}
