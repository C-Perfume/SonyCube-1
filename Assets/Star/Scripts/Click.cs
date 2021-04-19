using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Click : MonoBehaviour
{
    public Text click;
    public float dir = -1;
    Color color;
    float currT = 0;
        public float hideT = 2;
    void Start()
    {
        color = click.color;
    }
    void Update()
    {       currT += Time.deltaTime;
            color.a += 0.01f * dir;
            click.color = color;
            if (color.a >= 1 || color.a <= 0) dir *= -1;
        
        if (currT > hideT)
        {
            color.a = 0;
            click.color = color;
        }
    }
}
