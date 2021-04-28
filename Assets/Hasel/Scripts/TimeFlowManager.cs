using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeFlowManager : MonoBehaviour
{ 
    public static TimeFlowManager instance;
    public Text currTime;
    float Sec;
    int Min;
    int Hour;

    private void Start()
    {
        Sec = 55;
    }
    private void Update()
    {
        //if (GameManager.instance.gState != GameManager.GameState.Play) { return; }
        TimeFlow();
    }

    void TimeFlow()
    {
        Sec += Time.deltaTime;
        currTime.text = string.Format("{0:D2}:{1:D2}:{2:D2}", Hour, Min, (int)Sec);
        if ((int)Sec > 59)
        {
            Sec = 0;
            Min++;
        }
        else if (Min > 59)
        {
            Min = 0;
            Hour++;
        }
    }
}
