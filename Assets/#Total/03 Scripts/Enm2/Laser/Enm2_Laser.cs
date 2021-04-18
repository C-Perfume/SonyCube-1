using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enm2_Laser : MonoBehaviour
{
    public float speed = 10;
    public float destroyS = 7;

    void Start() 
    {
        Destroy(gameObject, destroyS);
    }

    void Update()
    {
    transform.Translate(Vector3.back * speed * Time.deltaTime); 
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    Destroy(other.gameObject);
    //}
}
