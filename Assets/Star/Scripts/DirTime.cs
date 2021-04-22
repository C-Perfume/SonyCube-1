using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirTime : MonoBehaviour
{
    float time = 0;
    public float startT = 1;
    public GameObject dir;
    bool istrue = false;
    int stop = 0;
     void Start()
    {
        GameObject dirP = Instantiate(dir);
        dirP.transform.position = transform.position;
        dirP.transform.eulerAngles = transform.eulerAngles;
        Destroy(dirP, 0.5f);
    }
       void Update()
    {
        time += Time.deltaTime;
        if (stop < 2)
        {
            if (time >= startT)
            {
                istrue = true;

                if (istrue)
                {
                    GameObject dirP = Instantiate(dir);
                    dirP.transform.position = transform.position;
                    dirP.transform.eulerAngles = transform.eulerAngles;
                    time = 0;
                    
                    Destroy(dirP, 0.5f); stop++;
                }
             }
        }
    }

}
