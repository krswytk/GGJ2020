using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlUP : MonoBehaviour
{
    Vector2 force;
    private bool JP;//ジャンプ判定
    private int JumpPower = 200;//ジャンプ力
    // Start is called before the first frame update
    void Start()
    {
        JP = true;

    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 pos = transform.position;
        Rigidbody2D up = GetComponent<Rigidbody2D>();
        if (Input.GetButtonDown("Jump"))
        {

            if (JP == true)
            {
                up.AddForce(new Vector2(0, JumpPower));
                JP = false;
            }
        }
        //transform.position = pos;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "floar"){
            JP = true;
        }
    }
}

