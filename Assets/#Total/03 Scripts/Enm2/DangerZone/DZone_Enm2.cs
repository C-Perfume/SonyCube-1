using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DZone_Enm2 : MonoBehaviour
{
    public float destT2 = 0;
    public float scaleT2 = 0.8f; 
    public float scaleSize2 = 1f;
    bool scale2 = true;
    float scaleCut2 = 0;
    public GameObject enemy;

    void Start()
    {
        Destroy(gameObject, destT2);
    }

    void Update()
    {
        //스케일이 1초마다 0에서 ?로 변하기
        if (scale2 && scaleCut2 < 1)
        {
            transform.localScale += new Vector3(scaleSize2, scaleSize2, scaleSize2) * Time.deltaTime * scaleT2;
            if (transform.localScale.z >= scaleSize2)
            {
                transform.localScale = new Vector3(scaleSize2, scaleSize2, scaleSize2);
                scale2 = false;
                scaleCut2++;
            }
        }        
    }
}
