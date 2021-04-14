using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlockEnemyX : MonoBehaviour
{
    //일정시간
    float thisTime = 2;
    //흐르는시간
    float currTime = 0;

    //적 이동속도
    public float MoveSpeed = 4;
    Vector3 dir;

    //이동가능
    bool movable = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    public float time = 0.8f;
    public GameObject cube;
    public float stayTime = 0.2f;
    int moveCnt;
    // Update is called once per frame
    void Update()
    {
        if(movable)
        {
            currTime += Time.deltaTime;
            transform.position += transform.right *  Time.deltaTime * (1 / time);
            cube.transform.Rotate(0, 0, -90 * Time.deltaTime * (1 / time));
            if(moveCnt >= 9)
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

            if(currTime > stayTime)
            {
                movable = true;
                currTime = 0;
            }
        }

        //Destroy(gameObject, 15);
    }
    /*
    void EnemyMove()
    {
        if (thisTime <= currTime)
        {
            movable = true;
        }
    }
    void trueMove()
    {
        if (movable)
        {
            transform.position += new Vector3(1, 0, 0) * Time.deltaTime;
            transform.eulerAngles += new Vector3(0, 0, -90) * Time.deltaTime;
            currTime = 0;
        }
        else
        {
            movable = false;
            transform.position = new Vector3(transform.position.x + 1, transform.position.y, transform.position.z);
        }
    } /*

    /* void NormalMove()
    {
        transform.position += transform.TransformDirection(Vector3.left) * MoveSpeed * Time.deltaTime;
    }*/
}
