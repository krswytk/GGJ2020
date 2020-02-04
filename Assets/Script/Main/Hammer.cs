using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : MonoBehaviour
{
    public GameObject Player;
    public float dis;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        dis = this.transform.position.x - Player.transform.position.x;

        if (dis < 3f) 
        {
            GetComponent<Rigidbody2D>().simulated = true;
        }
    }

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

            //audioSource.Play();
        }
    }
}
