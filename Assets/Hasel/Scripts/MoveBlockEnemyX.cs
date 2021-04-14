using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlockEnemyX : MonoBehaviour
{
    //흐르는시간
    float currTime = 0;
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
        if (movable)
        {
            currTime += Time.deltaTime;
            transform.position += transform.right * Time.deltaTime * (1 / time);
            cube.transform.Rotate(0, 0, -90 * Time.deltaTime * (1 / time));
            if (moveCnt >= 10)
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
        Destroy(gameObject, 18);
    }
}
