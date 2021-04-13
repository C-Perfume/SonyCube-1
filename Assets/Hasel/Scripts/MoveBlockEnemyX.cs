using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlockEnemyX : MonoBehaviour
{
    public float MoveSpeed = -4;
    Vector3 dir;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position += transform.TransformDirection(Vector3.left) * MoveSpeed * Time.deltaTime;
    }
}
