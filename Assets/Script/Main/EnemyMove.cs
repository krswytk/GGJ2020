using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMove : MonoBehaviour
{
    Rigidbody2D Enemy;
    private float Move = 3.0f;
    public AudioClip OverSE;
    private AudioSource audioSource;

    void Start()
    {

        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = OverSE;
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody2D Enemy=GetComponent<Rigidbody2D>();
        Enemy.velocity = new Vector2(Move, 0);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Kabe")
        {
            Move = Move * -1.0f;
        }

        if (collision.gameObject.name == "Player")
        {
            Transform Plpos = collision.transform;
            Vector2 pos = Plpos.position;


            pos.x = 0;
            pos.y = 2;

            Plpos.position = pos;
            audioSource.Play();

        }
    }
}
