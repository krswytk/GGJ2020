using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BakcColorChenge : MonoBehaviour
{
    public GameObject[] pos;
    private long kase;
    GameObject mainCamObj;
    Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        kase = 0;//0.1.2
        mainCamObj = GameObject.Find("Main Camera");
        cam = mainCamObj.GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject == pos[0])
        {
            cam.backgroundColor = new Color(194 / 255.0f, 243 / 255.0f, 240 / 255.0f, 255 / 255.0f);
            Debug.Log("ヒル");
        }
        if (collision.gameObject == pos[1])
        {
            cam.backgroundColor = new Color(241 / 255.0f, 142 / 255.0f, 90 / 255.0f, 255 / 255.0f);
            Debug.Log("夕方");
        }
        if (collision.gameObject == pos[2])
        {
            cam.backgroundColor = new Color(50 / 255.0f, 0 / 255.0f, 85 / 255.0f, 255 / 255.0f);
            Debug.Log("よる");
        }
    }
}
