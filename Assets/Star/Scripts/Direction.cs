using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Direction : MonoBehaviour
{
    public int destroyT = 5;
    //float dir = -1; 
    Color color;
    void Start()
    {
        Destroy(gameObject, destroyT);
        //color.a = 0;
    }

    // Update is called once per frame
    void Update()
    {
       // MeshRenderer mr = GetComponentInChildren<MeshRenderer>();
       // color = mr.material.color;
       // color.a = 0.01f * dir * Time.deltaTime;
       //if (color.a >= 1 || color.a <= 0) dir *= -1;
       

    }
}
