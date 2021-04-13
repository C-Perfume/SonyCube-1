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
            //적큐브 위치를 위로 10정도 올려진 곳에서 만들고 싶다. 어떻게??
            enemy2.transform.position = transform.position;
            realTime = 0;
        }
    }
}
