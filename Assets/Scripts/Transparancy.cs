using System.Collections;
using UnityEngine;

public class Transparancy : MonoBehaviour
{
    [SerializeField] private Material myMaterial;
    public static bool trigg;
    public static bool triggGameOver =false;
    public static bool startGame = false;
    //public float timeStart;
    public Color color;
    public static float count = 0;
    private void Start()
    {
        color = myMaterial.color;
        color.a = 0;
        myMaterial.color = color;
    }
    private void FixedUpdate()
    {
        if (startGame)
        {
            count += 0.5f;
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
                triggGameOver = true;
                count = 0;
            }
            myMaterial.color = color;
        }
        //Debug.Log(count);
    }

    //IEnumerator waitFS()
    //{
    //    yield return new WaitForSeconds(1);
    //}
}
