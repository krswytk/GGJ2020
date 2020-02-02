using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl_RL : MonoBehaviour
{
    Vector2 force;
    int count;
    int power = 20;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        count = PlayerDocking.RoboCount();
        switch (count)
        {
            case 0: power = 20;break;
            case 1: power = 23; break;
            case 2: power = 26; break;
            case 3: power = 29; break;
            case 4: power = 32; break;
            case 5: power = 35; break;
            default:power = 40;break;
        }

        if (rb.velocity.magnitude < 10.0f )
        {
            if (Input.GetKey(KeyCode.D))
            {
                //print("up arrow key is held down");

                //force = new Vector2(1000, 0);
                Vector2 force = new Vector2(power, 0);
                rb.AddForce(force);

            }
            else if (Input.GetKey(KeyCode.A))
            {
                //print("up arrow key is held down");

                //force = new Vector2(-1000, 0);
                Vector2 force = new Vector2(-power, 0);
                rb.AddForce(force);
            }
            else
            {
                rb.velocity = new Vector2(rb.velocity.x*0.5f, rb.velocity.y);
            }
        }/*else
        {
            rb.velocity = new Vector2(10,0);
            Debug.Log("制限速度");
        }*/


    }

      //a  rb.AddForce(force * 0.2f);
    
}
