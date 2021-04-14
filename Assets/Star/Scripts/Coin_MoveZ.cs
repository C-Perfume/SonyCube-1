using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_MoveZ : MonoBehaviour
{
    float currTime = 0;
    bool movable = true;
    public float time = 0.8f;
    public GameObject cube;
    public float stayTime = 0.2f;
    int moveCnt;
    public float flySpd = 3f;
    public float SpinSpd = 3f;
    bool backM = true;
    bool spin = false;
   
    void Start()
    { Destroy(gameObject, 13); }
    void Update()
    {
        if (backM)
        {
            movable = false;
            transform.position += Vector3.back * flySpd * Time.deltaTime;

            if (transform.position.z <= 4)
            {
                backM = false;
                movable = true;
                spin = true;

            }
        }
        if (spin)
        {
            cube.transform.Rotate(90 * SpinSpd * Time.deltaTime, 0, 0);
        }


        if (movable)
        {

            currTime += Time.deltaTime;
            transform.position -= transform.forward * Time.deltaTime * (1 / time);
            if (moveCnt >= 9)
            {
                transform.position -= transform.up * Time.deltaTime;
            }
            else if (currTime > time)
            {
                movable = false;
                currTime = 0;
                moveCnt++;
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
    //private void OnCollisionEnter(Collision collision)
    //{
    //    GameObject pl = GameObject.Find("Player");
    //    if ( pl == collision.gameObject.)
    //    { Destroy(gameObject); }
    //}
}
