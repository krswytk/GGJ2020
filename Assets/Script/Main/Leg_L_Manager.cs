using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leg_L_Manager : MonoBehaviour
{

    private float time;
    // Start is called before the first frame update
    // CarプレハブをGameObject型で取得
    public GameObject Car; 
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > 3)
        {
            Instantiate(Car, this.transform.position, Quaternion.identity);
            time = 0;
        }
    }
}
