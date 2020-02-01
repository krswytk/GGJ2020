using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AniOn : MonoBehaviour
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

        bool walk = animator.GetBool("ON");
        
            animator.SetBool("ON", true);
        if(this.gameObject.name == "Player")
        {
            if(PlayerDocking.RoboCount() > 0)
            {

                animator.SetBool("ON", false);
            }
        }
    }
}
