using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DZFire_Hasel : MonoBehaviour
{
    public GameObject dangerZF;
    public GameObject startP;
    float currT;
    float creatT = 1.5f;
    float dZoneCnt = 0;
    bool dz = false;

    private void Start()
    {
        currT = .95f;
    }
    void Update()
    {
        if (startP.transform.position.x > -6 && startP.transform.position.z < 6 && startP.transform.position.x < 5 && startP.transform.position.z > -5)
        {
            dz = true;
        }
        if (dz)
        {
            currT += Time.deltaTime;
            if (creatT < currT)
            {
                GameObject dZ = Instantiate(dangerZF);
                dZ.transform.position = transform.position;
                dZoneCnt++;
                currT = 0;
                //creatT += 0.03f;
            }
        }

        if (dZoneCnt > 7)
        {
            dz = false;
        }
    }
}
