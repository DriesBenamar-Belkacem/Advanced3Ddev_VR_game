using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{   
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            ResetTheGame();
        }
    }
    public void ResetTheGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        print("restarting...");
    }
}
