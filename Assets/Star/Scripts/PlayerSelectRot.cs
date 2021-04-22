using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelectRot : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        Transform target = GameObject.Find("Rotation").transform;

        Vector3 dir = target.position - transform.position;
        dir.Normalize();
        transform.forward = dir;
        
    }
}
