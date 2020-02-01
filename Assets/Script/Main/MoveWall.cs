using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWall : MonoBehaviour
{
    public Vector2 SPEED = new Vector2(0, 0.05f);//カベの移動速度
    bool sw = true;
    void Start()
    {
        
    }

    void Update()
    {

        // 移動処理

        Move();

    }

    // 移動関数

    void Move()
    {

        // 現在位置をPositionに代入

        Vector2 Position = transform.position;

        if (sw)
        {
            Position.y -= SPEED.y;
        }
        else
        {
            Position.y += SPEED.y;
        }
               

        if (Position.y >= 11.0f)
        {

            sw = true;

        }

        if (Position.y <= 6.0f)
        { 

           sw=false;

        }
        

        // 現在の位置に加算減算を行ったPositionを代入する

        transform.position = Position;

    }
}
