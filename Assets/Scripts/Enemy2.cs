using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    public float destroyT = 5;
    // Start is called before the first frame update
    void Start()
    {
       Destroy(gameObject, destroyT);
        destroyT = Time.deltaTime;
    }
}
