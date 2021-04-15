using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeAttack : MonoBehaviour
{
    public float currTime;
    public Text timerUI;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currTime -= Time.deltaTime;
        //timerUI.text = "Time : " + (int)(currTime);

        int min = (int)(currTime / 60);
        int sec = (int)(currTime % 60);

        timerUI.text = "Time : " + min + "Ка" + " " + sec + "УЪ";
    }
}
