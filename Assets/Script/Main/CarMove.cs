using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    public Rigidbody2D Car;
    public AudioClip OverSE;
    public float CarSpeed;
    private float time;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = OverSE;
        //Car = GetComponent<Rigidbody2D>();
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        Car.velocity = new Vector2(-CarSpeed, 0);
        //Move();
        if (time > 7)
        {
            Destroy(this.gameObject);
        }
    }
   /* private void OnCo (Collider2D collision)
    {
        Debug.Log("HIT");
        if (collision.gameObject.tag == "Player")
        {
            Transform Plpos = collision.transform;
            Vector2 pos = Plpos.position;


            pos.x = 0;
            pos.y = 2;

            Plpos.position = pos;

            audioSource.Play();
        }
    }*/

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.tag == "Player")
        {
            Transform Plpos = collision.transform;
            Vector2 pos = Plpos.position;


            pos.x = 0;
            pos.y = 2;

            Plpos.position = pos;

            audioSource.Play();
        }
    }
    void Move()
    {
        /*
        Transform pos = this.transform;
        Vector2 Position = pos.position;


        Position.x -= CarSpeed;
        // 現在の位置に加算減算を行ったPositionを代入する

        pos.position = Position;
        */

        //現在のpositionに移動速度を加算していく
        this.transform.position -= new Vector3(CarSpeed, 0, 0);
    }


}
