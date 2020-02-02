using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDocking : MonoBehaviour
{
    private static int ROBOCOUNT;
    private static bool[] ROBO = new bool[5];//0 body 1 LR 2 LL 3 AR 4 AL
    public GameObject[] pars;////0 body 1 LR 2 LL 3 AR 4 AL
    private AudioSource[] audioSource;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
       // ROBO = new PART();//クラスを生成
        ROBOCOUNT = 0;
        audioSource = gameObject.GetComponents<AudioSource>();
        for (int lp = 0; lp < ROBO.Length; lp++)
        {
            ROBO[lp] = false;
        }
         rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(ROBOCOUNT);
        switch (ROBOCOUNT)
        {
            case 0: rb.gravityScale = 1; break;
            case 1: rb.gravityScale = 2; break;
            case 2: rb.gravityScale = 3; break;
            case 3: rb.gravityScale = 4; break;
            case 4: rb.gravityScale = 5; break;
            case 5: rb.gravityScale = 5; break;
            case 6: rb.gravityScale = 6; break;
            default: rb.gravityScale = 7; break;
        }

    }

    public static int RoboCount()
    {
        return ROBOCOUNT;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Part")
        {
            collision.transform.parent = this.transform; //接触したパーツを子のオブジェクトに

            //重さ変更


            if(collision.gameObject.name == "BODY")//各ハーツごとの取得をboolで判断
            {
                if(ROBO[0] == false)
                {
                    audioSource[1].Play();
                }
                ROBO[0] = true;
               // pars[0].GetComponent<aniON>
                ROBOCOUNT++;
                SetBody(collision);
            }
            if (collision.gameObject.name == "AR")
            {
                if (ROBO[3] == false)
                {
                    audioSource[1].Play();
                }
                ROBO[3] = true;
                ROBOCOUNT++;
                SetAR(collision);
            }
            if (collision.gameObject.name == "AL")
            {
                if (ROBO[4] == false)
                {
                    audioSource[1].Play();
                }
                ROBO[4] = true;
                ROBOCOUNT++;
                SetAL(collision);
            }
            if (collision.gameObject.name == "LR")
            {
                if (ROBO[1] == false)
                {
                    audioSource[1].Play();
                }
                ROBO[1] = true;
                ROBOCOUNT++;
                SetLR(collision);
            }
            if (collision.gameObject.name == "LL")
            {
                if (ROBO[2] == false)
                {
                    audioSource[1].Play();
                }
                ROBO[2] = true;
                ROBOCOUNT++;
                SetLL(collision);
            }
            rb.velocity *= 0;
        }

    }


    public void SetBody(Collision2D ob)
    {
        if (ROBO[1] == false && ROBO[2] == false && ROBO[3] == false && ROBO[4] == false)
        {
            ROBO[0] = true;
            Transform obpos = ob.transform;
            Vector3 pos = obpos.localPosition;
            Vector3 rot = obpos.localEulerAngles;
            pos.x = 0;
            pos.y = -1.3f;
            rot.x = 0;
            rot.y = 0;
            rot.z = 0;
            obpos.localPosition = pos;
            obpos.localEulerAngles = rot;

            Transform PLPos = this.transform;
            Vector3 ppos = PLPos.position;
            ppos.y = 3;
            PLPos.position = ppos;
        }
        else
        {
            ROBO[0] = true;
            Transform obpos = ob.transform;
            Vector3 pos = obpos.localPosition;
            Vector3 rot = obpos.localEulerAngles;
            pos.x = 0;
            pos.y = 1.3f;
            rot.x = 0;
            rot.y = 0;
            rot.z = 180;
            obpos.localPosition = pos;
            obpos.localEulerAngles = rot;

            Transform PLPos = this.transform;
            Vector3 ppos = PLPos.position;
            ppos.y = 3;
            PLPos.position = ppos;
        }


    }
    public void SetLR(Collision2D ob)
    {
        if (ROBO[0] == true)
        {
            ROBO[1] = true;
            Transform obpos = ob.transform;
            Vector3 pos = obpos.localPosition;
            Vector3 rot = obpos.localEulerAngles;
            pos.x = 0.2f;
            pos.y = -2.5f;
            rot.x = 0;
            rot.y = 0;
            rot.z = 0;
            obpos.localPosition = pos;
            obpos.localEulerAngles = rot;

            Transform PLPos = this.transform;
            pos = PLPos.position;
            pos.y = 3;
            PLPos.position = pos;

        }
        else
        {
            ROBO[1] = true;
            Transform obpos = ob.transform;
            Vector3 pos = obpos.localPosition;
            Vector3 rot = obpos.localEulerAngles;
            pos.x = 0.2f;
            pos.y = -1.3f;
            rot.x = 0;
            rot.y = 0;
            rot.z = 0;
            obpos.localPosition = pos;
            obpos.localEulerAngles = rot;

            Transform PLPos = this.transform;
            pos = PLPos.position;
            pos.y = 3;
            PLPos.position = pos;
        }
    }
    public void SetLL(Collision2D ob)
    {
        if (ROBO[0] == true)
        {
            ROBO[2] = true;
            Transform obpos = ob.transform;
            Vector3 pos = obpos.localPosition;
            Vector3 rot = obpos.localEulerAngles;
            pos.x = 0.2f;
            pos.y = -2.5f;
            rot.x = 0;
            rot.y = 0;
            rot.z = 0;
            obpos.localPosition = pos;
            obpos.localEulerAngles = rot;

            Transform PLPos = this.transform;
            pos = PLPos.position;
            pos.y = 3;
            PLPos.position = pos;

        }
        else
        {
            ROBO[2] = true;
            Transform obpos = ob.transform;
            Vector3 pos = obpos.localPosition;
            Vector3 rot = obpos.localEulerAngles;
            pos.x = 0.2f;
            pos.y = -1.3f;
            rot.x = 0;
            rot.y = 0;
            rot.z = 0;
            obpos.localPosition = pos;
            obpos.localEulerAngles = rot;

            Transform PLPos = this.transform;
            pos = PLPos.position;
            pos.y = 3;
            PLPos.position = pos;
        }
    }
    public void SetAR(Collision2D ob)
    {
        if(ROBO[0] == true)
        {
            ROBO[3] = true;
            Transform obpos = ob.transform;
            Vector3 pos = obpos.localPosition;
            Vector3 rot = obpos.localEulerAngles;
            pos.x = 0.13f;
            pos.y = -1.3f;
            rot.x = 0;
            rot.y = 0;
            rot.z = 0;
            obpos.localPosition = pos;
            obpos.localEulerAngles = rot;

            Transform PLPos = this.transform;
            pos = PLPos.position;
            pos.y = 3;
            PLPos.position = pos;

        }
        else
        {
            ROBO[3] = true;
            Transform obpos = ob.transform;
            Vector3 pos = obpos.localPosition;
            Vector3 rot = obpos.localEulerAngles;
            pos.x = 0.13f;
            pos.y = -1f;
            rot.x = 0;
            rot.y = 0;
            rot.z = 0;
            obpos.localPosition = pos;
            obpos.localEulerAngles = rot;

            Transform PLPos = this.transform;
            pos = PLPos.position;
            pos.y = 3;
            PLPos.position = pos;
        }
    }
    public void SetAL(Collision2D ob)
    {
        if (ROBO[0] == true)
        {
            ROBO[4] = true;
            Transform obpos = ob.transform;
            Vector3 pos = obpos.localPosition;
            Vector3 rot = obpos.localEulerAngles;
            pos.x = 0.13f;
            pos.y = -1.3f;
            rot.x = 0;
            rot.y = 0;
            rot.z = 0;
            obpos.localPosition = pos;
            obpos.localEulerAngles = rot;

            Transform PLPos = this.transform;
            pos = PLPos.position;
            pos.y = 3;
            PLPos.position = pos;

        }
        else
        {
            ROBO[4] = true;
            Transform obpos = ob.transform;
            Vector3 pos = obpos.localPosition;
            Vector3 rot = obpos.localEulerAngles;
            pos.x = 0.13f;
            pos.y = -1f;
            rot.x = 0;
            rot.y = 0;
            rot.z = 0;
            obpos.localPosition = pos;
            obpos.localEulerAngles = rot;

            Transform PLPos = this.transform;
            pos = PLPos.position;
            pos.y = 3;
            PLPos.position = pos;
        }
    }
}


public class PART{//ロボのパーツ取得状況を管理するクラス
    public bool BODY;
    public bool AR;
    public bool AL;
    public bool LR;
    public bool LL;

    public PART()
    {
        BODY = false;
        AR = false;
        AL = false;
        LR = false;
        LL = false;
    }

    public void SetBODY()
    {
        BODY = true;
    }
    public void SetAR()
    {
        AR = true;
    }
    public void SetAL()
    {
        AL = true;
    }
    public void SetLR()
    {
        LR = true;
    }
    public void SetLL()
    {
        LL = true;
    }

    public bool GetBODY()
    {
        return BODY;
    }
    public bool GetAR()
    {
        return AR;
    }
    public bool GetAL()
    {
        return AL;
    }
    public bool GetLR()
    {
        return LR;
    }
    public bool GetLL()
    {
        return LL;
    }


}
