using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Fire : MonoBehaviour
{
    float realTime;
    public float creatTime = 0.5f;
    public GameObject laserF;
    int laserCnt=0;
    bool laserA = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //�ѹ��� ������ �ϰ� ������.. ��ŸƮ������ �ȵȴ�
        
        realTime += Time.deltaTime;

        if (laserA)
        {
            if (creatTime < realTime)
            {
                GameObject laser = Instantiate(laserF);
                laser.transform.position = transform.position;
                realTime = 0;
                laserCnt++;
                if (laserCnt >= 1)
                { laserA = false; }
            }
        }
    }
}
