using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Fire : MonoBehaviour
{
    float realTime;
    public float creatTime = 1;
    public GameObject laserF;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //한번만 나가게 하고 싶은데.. 스타트에서는 안된다
        realTime += Time.deltaTime;
        if (creatTime < realTime)
        {
            GameObject laser = Instantiate(laserF);
            laser.transform.position = transform.position;
            realTime = 0;
        }
    }
}
