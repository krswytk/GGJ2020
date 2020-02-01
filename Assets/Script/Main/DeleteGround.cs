using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteGround : MonoBehaviour
{
    public GameObject Plane1,Plane2,Plane3;//床
    float time1 = 6.0f;
    float time2 = 4.0f;
    float time3 = 2.0f;
    void Update()
    {
        time1 += Time.deltaTime;
        time2 += Time.deltaTime;
        time3 += Time.deltaTime;

        if (time1 > 7.0f)
        {
            if (Plane1.activeSelf == false)
            {
                Plane1.SetActive(true);
                time1 = 0;
            }
            else
            {
                Plane1.SetActive(false);
                time1 = 0;
            }
        }

        if (time2 > 7.0f)
        {
            if (Plane2.activeSelf == false)
            {
                Plane2.SetActive(true);
                time2 = 0;
            }
            else
            {
                Plane2.SetActive(false);
                time2 = 0;
            }
        }

        if (time3 > 7.0f)
        {
            if (Plane3.activeSelf == false)
            {
                Plane3.SetActive(true);
                time3 = 0;
            }
            else
            {
                Plane3.SetActive(false);
                time3 = 0;
            }
        }
    }
}
