using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrienttoPoint : MonoBehaviour
{
    void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, .25f);
    }
}
