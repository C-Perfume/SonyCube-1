using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlockEnemyZ : MonoBehaviour
{
    public float MoveSpeed = 4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.TransformDirection(Vector3.back) * MoveSpeed * Time.deltaTime;
    }
}
