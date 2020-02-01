using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl_RL : MonoBehaviour
{
    Vector2 force;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        if (Input.GetKey(KeyCode.D))
        {
            //print("up arrow key is held down");

            //force = new Vector2(1000, 0);

            rb.AddForce(new Vector2(10, 0));

        }
        if (Input.GetKey(KeyCode.A))
        {
            //print("up arrow key is held down");

            //force = new Vector2(-1000, 0);
            rb.AddForce(new Vector2(-10,0 ));

        }

        rb.AddForce(force * 0.2f);
    }
}
