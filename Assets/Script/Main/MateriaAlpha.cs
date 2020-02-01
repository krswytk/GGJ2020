using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MateriaAlpha : MonoBehaviour
{

    MeshRenderer mr;
    float time;
    void Start()
    {
        mr = GetComponent<MeshRenderer>();
        time = 0;

    }

    // Update is called once per frame
    void Update()
    {
        time+= Time.deltaTime; 
        if (time < 7.0f)
        {
            mr.material.color = mr.material.color + new Color32(0, 0, 0, 255);
        }
        else
        {
            mr.material.color = mr.material.color - new Color32(0, 0, 0, 255);
        }
    }
}
