using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_OnTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("Pla")) Destroy(gameObject);
    }
   }

