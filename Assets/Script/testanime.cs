using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testanime : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {

        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //  Rigidbody2D rb = GetComponent<Rigidbody2D>();
        //bool walk = animator.GetBool("ON");

        if (Input.GetKey(KeyCode.D))
        {
            //print("up arrow key is held down");

            //force = new Vector2(1000, 0);

            //  rb.AddForce(new Vector2(10, 0));
            animator.SetBool("ON", true);
            //Debug.Log("Ck");

        }
        else if (Input.GetKey(KeyCode.A))
        {
            //print("up arrow key is held down");

            //force = new Vector2(-1000, 0);
            //   rb.AddForce(new Vector2(-10, 0));
            animator.SetBool("ON", true);
            //Debug.Log("Ck");

        }
        else
        {

            animator.SetBool("ON", false);
        }

        //  rb.AddForce(force * 0.2f);
    }
}
