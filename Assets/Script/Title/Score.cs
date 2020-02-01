using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    string score;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        score = PlayerDocking.RoboCount().ToString();
        text.text = "SCORE : " + score;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
