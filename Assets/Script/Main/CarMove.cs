using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    Rigidbody2D Car;
    public AudioClip OverSE;
    public float CarSpeed = 0.5f;
    private float time;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = OverSE;
        this.Car = GetComponent<Rigidbody2D>();
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        Move();
        if (time > 2)
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
    }
    void Move()
    {
        Transform pos = this.transform;
        Vector2 Position = pos.position;


        Position.x -= CarSpeed;
        // 現在の位置に加算減算を行ったPositionを代入する

        pos.position = Position;

    }


}
