using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Man : MonoBehaviour
{
    float realTime;
    public float creatTime = 2;
    public GameObject enemy2F;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        realTime += Time.deltaTime;

        if (creatTime < realTime) 
        {
           GameObject enemy2 = Instantiate(enemy2F);
            //��ť�� ��ġ�� ���� 10���� �÷��� ������ ����� �ʹ�. ���??
            enemy2.transform.position = transform.position;
            realTime = 0;
        }
    }
}
