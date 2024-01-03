using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    public TMP_Text counter;
    public int Score;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Score = player.GetComponent<CubeCollector>().Score; // grabs the Score int from CapsuleCollect.cs
        counter.text = Score.ToString(); //apply score to the onscreen counter
    }
}
