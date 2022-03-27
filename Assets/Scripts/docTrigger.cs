using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class docTrigger : MonoBehaviour
{
    [SerializeField] private Material myMaterialDoc;
    [SerializeField] private TextMeshProUGUI GameIsOverText;
    public GameObject secretarry;
    public GameObject lunchlady;
    public GameObject npcFemale;
    public GameObject npcMale;
    private Animation doc;
    public static bool gameOver;
    public AudioSource victorySound;
    public Color color;

    void Start()
    {
        doc = gameObject.GetComponent<Animation>();
        GameIsOverText.enabled = false;
        color = myMaterialDoc.color;        
        myMaterialDoc.color = color;
    }

    void Update()
    {
            doc.Play("Idle");      
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            victorySound.Play();
            GameIsOverText.enabled = true;
            Transparancy.startGame = false;
            WalkInRandomDirection.endGame = true;
            GameObject.Destroy(this.secretarry);
            GameObject.Destroy(this.lunchlady);
            GameObject.Destroy(this.npcFemale);
            GameObject.Destroy(this.npcMale);
            gameOver = true;
            Debug.Log("arrived at ehbo");
            doc.Play("Hello");
            color.a = 0;
            myMaterialDoc.color = color;
        }        
    }
}

