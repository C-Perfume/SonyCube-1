using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DZone_Enm1 : MonoBehaviour
{
    public float destT = 0;
    public float scaleT = 0.8f; 
    public float scaleSize1 = 1f;
    bool scale1 = true;
    float scaleCut1 = 0;

    void Start()
    {
        Destroy(gameObject, destT);
    }

    void Update()
    {
        //스케일이 1초마다 0에서 ?로 변하기
        if (scale1 && scaleCut1 < 1)
        {
            transform.localScale += new Vector3(scaleSize1, scaleSize1, scaleSize1) * Time.deltaTime * scaleT;
            if (transform.localScale.z >= scaleSize1)
            {
                transform.localScale = new Vector3(scaleSize1, scaleSize1, scaleSize1);
                scale1 = false;
                scaleCut1++;
            }
        }
    }
}