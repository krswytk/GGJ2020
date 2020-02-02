using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class TimeOn : MonoBehaviour
{
    public GameObject[] sense;
    private float time;
    private int no;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        no = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene("Main");
        }
        time += Time.deltaTime;
        //Debug.Log(no);
        if(time > 3)
        {
            no += 1;
            time = 0;
            //Debug.Log("TIMEUP");
        }

        if (Input.GetMouseButtonDown(0))
        {
            no += 1;
            time = 0;
            Debug.Log("DOWNMOUSE");
        }

        switch (no)
        {
            case 1:
                sense[0].SetActive(true);
                break;
            case 2:
                sense[1].SetActive(true);
                break;
            case 3:
                sense[2].SetActive(true);
                break;
            case 4:
                sense[3].SetActive(true);
                break;
            case 5:
                SceneManager.LoadScene("Main");
                break;
        }
    }

}
