using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMove : MonoBehaviour
{
    Rigidbody2D Enemy;
    private float Move = 3.0f;

    void Start()
    {
        
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
            Debug.Log("当たり");
            Move = Move * -1.0f;
        }

        if (collision.gameObject.tag == "Player")
        {

            SceneManager.LoadScene("Score");
        }
    }
}
