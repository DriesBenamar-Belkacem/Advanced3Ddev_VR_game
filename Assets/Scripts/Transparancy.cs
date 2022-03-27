using System.Collections;
using UnityEngine;

public class Transparancy : MonoBehaviour
{
    [SerializeField] private Material myMaterial;
    public static bool trigg;
    public static bool triggGameOver;
    public static bool startGame;
    public Color color;
    public static float count = 0;
    private void Start()
    {
        triggGameOver = false;
        startGame = false;
        color = myMaterial.color;
        color.a = 0;
        myMaterial.color = color;
    }
    private void FixedUpdate()
    {
        if (startGame)
        {
            count += 0.5f;            
            color = myMaterial.color;
            if (count % 5 == 0)
            {
                color.a += 0.01f;
            }
            if (color.a >= 1.0f)
            {
                color.a = 0;
                trigg = false;
                triggGameOver = true;
                count = 0;
            }
            if(trigg)
            {
                color.a = 0;
                trigg = false;
                count = 0;
            }
            if (docTrigger.gameOver)
            {
                color.a = 0;                
            }
            myMaterial.color = color;
        }
    }
}
