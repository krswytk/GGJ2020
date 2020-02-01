using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movefloar : MonoBehaviour
{
    public float Max;

    public float Min;
    bool up;

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        float a = Random.value;
        if(a > 0.5)
        {
            up = true;
        }
        else
        {
            up = false;
        }
    }

    // Update is called once per frame
    void Update()
    {

        rb = GetComponent<Rigidbody2D>();
        Transform Mypos = this.transform;
        Vector2 pos = Mypos.position;

        if(pos.y < Min)
        {
            up = true;
            Mypos.position = new Vector2(pos.x, Min);
        }
        else if(pos.y > Max)
        {
            up = false;
            Mypos.position = new Vector2(pos.x, Max);
        }


        if(up == true)
        {
            rb.AddForce(new Vector2(0, 30));
        }else if(up == false)
        {
            rb.AddForce(new Vector2(0, -30));
        }
    }
}
