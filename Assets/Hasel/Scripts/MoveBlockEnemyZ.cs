using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlockEnemyZ : MonoBehaviour
{
    public float MoveSpeed = 4;

    //�����ð�
    //float thisTime = 2;
    //�帣�½ð�
    float currTime = 0;

    //�̵�����
    bool movable = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float time;
    public GameObject cube;
    public float stayTime = 0.5f;
    int moveCnt;

    // Update is called once per frame
    void Update()
    {
        //transform.position += transform.TransformDirection(Vector3.back) * MoveSpeed * Time.deltaTime;
        if (movable)
        {
            currTime += Time.deltaTime;
            transform.position += transform.forward * Time.deltaTime * (1 / time);
            cube.transform.Rotate(0, 0, -90 * Time.deltaTime * (1 / time));
            if (moveCnt >= 9)
            {
                transform.position -= transform.up * Time.deltaTime;
            }
            else if (currTime > time)
            {
                movable = false;
                currTime = 0;
                moveCnt++;
                print(moveCnt);
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
    }
}
