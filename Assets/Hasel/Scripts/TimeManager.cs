using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public Text timeText;
    float Sec;
    int Min;
    int Hour;

    private void Start()
    {
        Sec = 55;
    }
    private void Update()
    {
        TimeFlow();
    }

    void TimeFlow()
    {
        Sec += Time.deltaTime;
        timeText.text = string.Format("{0:D2}:{1:D2}:{2:D2}", Hour, Min, (int)Sec);
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
