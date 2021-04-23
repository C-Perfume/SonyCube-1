using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CmoveX : MonoBehaviour
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

    void Start()
    { Destroy(gameObject, 13); }
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

    private void OnCollisionEnter(Collision collision)
    {
        GameObject pl = GameObject.Find("Player");
        if (pl == collision.gameObject)
        { 
            Destroy(gameObject);
            CoinScore.instance.AddCoin(Random.Range(8,12));
        }
    }
    //private void OnCollisionEnter(Collision collision)
    //{
    //    //������ ���Ե� �浹ü�� �ִٸ�
    //    if (collision.gameObject.name.Contains("Spawn"))
    //    {// Rigidbody ������Ʈ�� �����ͼ� 
    //        Rigidbody rb = GetComponent<Rigidbody>();
    //        //ȸ���� ��ٴ�.
    //        rb.constraints = RigidbodyConstraints.None;
    //    }
    //}
}
