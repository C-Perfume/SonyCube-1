using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlockEnemyZ : MonoBehaviour
{

    float currTime = 0;
    bool movable = true;
    public float time = 1f;
    public GameObject cube;
    public float stayTime = 1f;
    int moveCnt;

    void Update()
    {
        if (movable)
        {
            currTime += Time.deltaTime;
            transform.position -= transform.forward * Time.deltaTime * (1 / time);
            cube.transform.Rotate(-90 * Time.deltaTime * (1 / time), 0, 0);

            if (moveCnt >= 10)
            {
                transform.position -= transform.up * Time.deltaTime;
            }

            else if (currTime > time)
            {
                float f = currTime - time;

                movable = false;
                currTime = 0;
                moveCnt++;
                //print(moveCnt);

                //print(f);
                cube.transform.Rotate(90 * f * (1 / time), 0, 0);
                transform.position += transform.forward * f * (1 / time);
            }
        }
        else
        {
            currTime += Time.deltaTime;

            if (currTime > stayTime)
            {
                movable = true;
                currTime = 0;
            }
        }

        Destroy(gameObject, 18);
        //����ƽ ��ȯ���ɼ�+1
    }
}
