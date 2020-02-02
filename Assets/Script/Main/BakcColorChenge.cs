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
            cam.backgroundColor = new Color(179 / 255.0f, 190 / 255.0f, 188 / 255.0f, 255 / 255.0f);
        }
        if (collision.gameObject == pos[1])
        {
            cam.backgroundColor = new Color(181 / 255.0f, 217 / 255.0f, 211 / 255.0f, 255 / 255.0f);
        }
        if (collision.gameObject == pos[2])
        {
            cam.backgroundColor = new Color(91 / 255.0f, 255 / 255.0f, 228 / 255.0f, 255 / 255.0f);
        }
        if (collision.gameObject == pos[3])
        {
            cam.backgroundColor = new Color(255 / 255.0f, 251 / 255.0f, 172 / 255.0f, 255 / 255.0f);
        }
        if (collision.gameObject == pos[4])
        {
            cam.backgroundColor = new Color(255 / 255.0f, 169 / 255.0f, 49 / 255.0f, 255 / 255.0f);
        }
        if (collision.gameObject == pos[5])
        {
            cam.backgroundColor = new Color(55 / 255.0f, 0 / 255.0f, 130 / 255.0f, 255 / 255.0f);
        }
        if (collision.gameObject == pos[6])
        {
            cam.backgroundColor = new Color(0 / 255.0f, 0 / 255.0f, 0 / 255.0f, 255 / 255.0f);
        }
    }
}
