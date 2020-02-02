using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleShake : MonoBehaviour
{

    public float setShakeTIme=2; // 持続振動時間

    private float time;

    private float lifeTime;

    private Vector3 savePosition;

    private float lowRangeX;

    private float maxRangeX;

    private float lowRangeY;

    private float maxRangeY;



    void CatchShake()
    {

        savePosition = transform.position;

        lowRangeY = savePosition.y - 0.1f;

        maxRangeY = savePosition.y + 0.1f;

        lowRangeX = savePosition.x - 0.1f;

        maxRangeX = savePosition.x + 0.1f;

        lifeTime = setShakeTIme;

    }



    void Start()
    {

        time = 2;
        if (setShakeTIme <= 0.0f)

            setShakeTIme = 0.7f;

        lifeTime = 0.0f;

    }



    void Update()
    {
        time += Time.deltaTime;
        if (lifeTime < 0.0f)
        {

            transform.position = savePosition;

            lifeTime = 0.0f;

        }



        if (lifeTime > 0.0f)
        {

            lifeTime -= Time.deltaTime;

            float x_val = Random.Range(lowRangeX, maxRangeX);

            float y_val = Random.Range(lowRangeY, maxRangeY);

            transform.position = new Vector3(x_val, y_val, transform.position.z);

        }

        if (time > 2)
        {
            CatchShake();
            time = 0;
        }

    }
}