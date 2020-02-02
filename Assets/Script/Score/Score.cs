using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int Parts;
    private float tm;
    private int score;
    public Text text1;
    public Text text2;
    public Text text3;
    // Start is called before the first frame update
    void Start()
    {
        Parts = PlayerDocking.RoboCount();
        tm    = TimerText.time;
        score= (int)(tm/ Parts);
        text1.text = "Parts : " + Parts;
        text2.text = "Time：" + (int)tm;
        text3.text = "Score：" + score;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
