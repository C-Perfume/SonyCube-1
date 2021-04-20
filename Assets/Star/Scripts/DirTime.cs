using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirTime : MonoBehaviour
{
    float time = 0;
    public float startT = 2;
    public GameObject dir;
    bool istrue = false;
    int stop = 0;
    // Start is called before the first frame update
    void Update()
    {
        time += Time.deltaTime;
        if (stop == 0)
        {
            if (time >= startT)
            {
                istrue = true;

                if (istrue)
                {
                    GameObject dirP = Instantiate(dir);
                    dirP.transform.position = transform.position;
                    dirP.transform.eulerAngles = transform.eulerAngles;
                    stop++;
                }
             }
        }
    }

}
