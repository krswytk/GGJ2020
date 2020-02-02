using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camer0 : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Transform pps = Player.transform;   //プレイヤーの位置取得
        Vector3 plpos = pps.position;       //

        Transform MyPos = this.transform;   //カメラオブジェクトの座標取得
        //Vector3 pos = MyPos.localPosition;
        Vector3 ppos = MyPos.position; ;

        if (plpos.y < 6 && plpos.y > 1)
        {
            ppos.x = plpos.x + 4;
            ppos.y = 2;
            ppos.z = -10;
        }else if(plpos.y >= 6)
        {
            ppos.x = plpos.x + 4;
            ppos.y = plpos.y/3;
            ppos.z = -10;
        }else if(plpos.y <= 1)
        {
            ppos.x = plpos.x + 4;
            ppos.y = plpos.y*2;
            ppos.z = -10;
        }


        MyPos.position = ppos;
    }
}
