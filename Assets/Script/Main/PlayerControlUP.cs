using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerControlUP : MonoBehaviour
{
    Vector2 force;
    private bool JP;//ジャンプ判定
    private float JumpPower;//ジャンプ力
    public AudioClip JumpSE;
    private AudioSource audioSource;
    private int power;
    // Start is called before the first frame update
    void Start()
    {
        JP = true;
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip =JumpSE;
    }

    // Update is called once per frame
    void Update()
    {
        power = PlayerDocking.RoboCount();
        switch (power)
        {
            case 0: JumpPower = 7;break;
            case 1: JumpPower = 11; break;
            case 2: JumpPower = 14; break;
            case 3: JumpPower = 16; break;
            case 4: JumpPower = 17; break;
            case 5: JumpPower = 18; break;
            case 6: JumpPower = 29; break;
            default:JumpPower = 35;break;
        }
        //Vector3 pos = transform.position;
        Rigidbody2D up = GetComponent<Rigidbody2D>();
        if (Input.GetButtonDown("Jump"))
        {

            if (JP == true)
            {
                Vector2 force = new Vector2(0,JumpPower);
                up.AddForce(force, ForceMode2D.Impulse);
                JP = false;
                audioSource.Play();
            }
        }

        if (Input.GetKey(KeyCode.S))
        {

            Vector2 force = new Vector2(0, -1);
            up.AddForce(force, ForceMode2D.Impulse);
        }
        //transform.position = pos;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        
          JP = true;
        /*
         * if(collision.gameObject.tag == "floar"){
            JP = true;
        }
        */
    }
}

