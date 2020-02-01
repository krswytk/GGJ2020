using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl_RL : MonoBehaviour
{
    Vector2 force;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        bool walk = animator.GetBool("Walk");

        if (Input.GetKey(KeyCode.D))
        {
            //print("up arrow key is held down");

            //force = new Vector2(1000, 0);

            rb.AddForce(new Vector2(10, 0));
            animator.SetBool("Walk", true);

        }
        else if (Input.GetKey(KeyCode.A))
        {
            //print("up arrow key is held down");

            //force = new Vector2(-1000, 0);
            rb.AddForce(new Vector2(-10,0 ));
            animator.SetBool("Walk", true);

        }
        else
        {

            animator.SetBool("Walk", false);
        }

        rb.AddForce(force * 0.2f);
    }
}
