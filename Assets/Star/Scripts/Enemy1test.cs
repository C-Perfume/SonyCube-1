using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1test : MonoBehaviour
{
    float currTime = 0; //흐르는시간
    bool movable = false; //이동 여부

    public float time = 1f;
    public GameObject cube;
    public float stayTime = 1f;
    int moveCnt;

    float deathtime1 = 0;
    public float deathtime2 = 18;

    bool rightM = true;
    public float flySpeed = 7;

    private void Start()
    {

    }
    void Update()
    {
        if (rightM)
        {
            transform.position += Vector3.right * flySpeed * Time.deltaTime;
            if (transform.position.x >= -4)
            {
                rightM = false;
            }
        }
        else if (movable)
        {
            currTime += Time.deltaTime;
            transform.position += transform.right * Time.deltaTime * (1 / time);
            cube.transform.Rotate(0, 0, -90 * Time.deltaTime * (1 / time));

            if (moveCnt >= 8)
            {
                transform.position -= transform.up * Time.deltaTime;
            }

            else if (currTime > time)
            {
                float f = currTime - time;

                movable = false;
                currTime = 0;
                moveCnt++;

                cube.transform.Rotate(0, 0, 90 * f * (1 / time));
                transform.position -= transform.right * f * (1 / time);
            }
        }
        else if (!movable)
        {
            currTime += Time.deltaTime;

            if (currTime > stayTime)
            {
                movable = true;
                currTime = 0;
            }
        }
        deathtime1 += Time.deltaTime;
        if (deathtime1 > deathtime2)
        {
            deathtime1 = 0;
            Destroy(gameObject);
            EnemyManagement.Enm1Cnt = 0;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.name.Contains("Ene"))
        {
            Destroy(other.gameObject);
        }
    }
}
