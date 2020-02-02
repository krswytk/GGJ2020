using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutArea : MonoBehaviour
{
    public AudioClip OverSE;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = OverSE;
    }

    // Update is called once per frame
    void Update()
    {

    }

    //当たり判定
    private void OnTriggerEnter2D(Collider2D collision)
    {

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
