using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContlorAnime : MonoBehaviour
{
    Animator animator;
    float speed;
    int num;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void AnimParam()
    {
        animator.SetFloat("Float", speed);

        animator.SetInteger("Int", num);

        animator.SetBool("Bool", true);
        animator.SetBool("Bool", false);

        animator.SetTrigger("Trigger");
    }
}