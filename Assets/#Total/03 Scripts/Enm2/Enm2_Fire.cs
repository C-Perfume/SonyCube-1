using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enm2_Fire : MonoBehaviour
{
    float realTime;
    public float creatTime = 0.5f;
    public GameObject laserF;
    int laserCnt=0;
    bool laserA = true;
    
    public GameObject dangerZF;
    public float dZonePosition = -0.3f;

    void Start()
    {
        GameObject dZ = Instantiate(dangerZF);
        dZ.transform.position = new Vector3(transform.position.x, dZonePosition, transform.position.z);
    }

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
