using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rot0 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform MyPos = this.transform;

        Vector3 rot = MyPos.eulerAngles;
        rot.x = 0;
        rot.y = 0;
        rot.z = 0;

        MyPos.eulerAngles = rot;
    }

}
