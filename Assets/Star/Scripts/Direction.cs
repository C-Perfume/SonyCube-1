using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Direction : MonoBehaviour
{
    public int destroyT = 5;
    void Start()
    {
        Destroy(gameObject, destroyT);
    }

   
}
