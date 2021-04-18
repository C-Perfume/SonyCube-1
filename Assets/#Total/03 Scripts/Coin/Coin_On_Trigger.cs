using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_On_Trigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("Pla")) Destroy(gameObject);
    }
    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.name.Contains("Playe")) Destroy(gameObject);
    //}
}

