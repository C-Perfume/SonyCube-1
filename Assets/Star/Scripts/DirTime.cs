using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirTime : MonoBehaviour
{
    float time = 0;
    public float startT = 1;
    
    GameObject dirF;
    public GameObject dir;
    public GameObject[] dirP;
    bool istrue = false;
    int stop = 0;
     void Start()
    {
        for (int i = 0; i <= 3; i++)
        { dirF = Instantiate(dir);
            dirF.transform.position = dirP[i].transform.position;
            dirF.transform.eulerAngles = dirP[i].transform.eulerAngles; }

        if (GameManager.instance.gState != GameManager.GameState.Play)
        { return; }

        Destroy(dirF, 0.5f);
    }
       void Update()
    {
        if (GameManager.instance.gState != GameManager.GameState.Play)
        { return; }

        time += Time.deltaTime;
        if (stop < 2)
        {
            if (time >= startT)
            {
                istrue = true;

                if (istrue)
                {
                    for (int i = 0; i <= 3; i++)
                    {
                        dirF = Instantiate(dir);
                    dirF.transform.position = dirP[i].transform.position;
                    dirF.transform.eulerAngles = dirP[i].transform.eulerAngles;
                    Destroy(dirF, 0.5f); stop++;
                    }
                }
             }
        }
    }

}
