using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Drag : MonoBehaviour
{
    public Text drag;
    public float dir = -1;
    public Color color;
    bool start = true;


    // Start is called before the first frame update
    void Start()
    {
        color = drag.color;
    }

    // Update is called once per frame
    void Update()
    { 
       if (start)
        { 
            color.a += 0.01f * dir;
            drag.color = color;
            if (color.a >= 1 || color.a <= 0) dir *= -1;

        }
        if (Input.GetButtonDown("Fire1"))
        { color.a = 0;
            drag.color = color; 
            start = false;
        }
    }
}
