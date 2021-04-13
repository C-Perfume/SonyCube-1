using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Man : MonoBehaviour
{
    float realTime;
    public int creatTime; 
    public GameObject enemy2F;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        realTime += Time.deltaTime;
        creatTime = Random.Range(5, 15);
        if (creatTime < realTime) 
        {
            GameObject enemy2 = Instantiate(enemy2F);
            enemy2F.transform.position = transform.position;
            realTime = 0;
        }
    }
}