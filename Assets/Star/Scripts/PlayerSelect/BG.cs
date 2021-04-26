using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG : MonoBehaviour
{
    public float speed = 0.1f;
    Vector3 originP;
    private void Start()
    {
        originP = transform.position;
    }
    void Update()
    {
        transform.position -= transform.right * speed * Time.deltaTime;
        if (transform.position.x == originP.x-18) { transform.position = originP; }
    }
}
