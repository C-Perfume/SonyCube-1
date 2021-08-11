using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_MoveX : MonoBehaviour
{
    float currTime = 0;
    bool movable = true;
    public float time = 0.8f;
    public GameObject cube;
    public float stayTime = 0.2f;
    int moveCnt;
    public float flySpd = 3f;
    public float SpinSpd = 3f;
    bool rightM = true;
    bool spin = false;
    public float destroyT = 13;

    void Start()
    { Destroy(gameObject, destroyT); }

    void Update()
    {
        if (rightM)
        {
            movable = false;
            transform.position += Vector3.right * flySpd * Time.deltaTime;

            if (transform.position.x >= -4)
            { 
                rightM = false;
                movable = true;
                spin = true;
                
            }
        }
        if (spin) 
        {
            if (cube != null) cube.transform.Rotate(0, 90 * SpinSpd * Time.deltaTime, 0);

        }
        if (movable)
        {

            currTime += Time.deltaTime;
            transform.position += transform.right * Time.deltaTime * (1 / time);
            if (moveCnt >= 9)
            {
                transform.position -= transform.up * Time.deltaTime;
            }
            else if (currTime > time)
            {              
                moveCnt++;
                currTime = 0;
            }
        }
        
    }
   
}
