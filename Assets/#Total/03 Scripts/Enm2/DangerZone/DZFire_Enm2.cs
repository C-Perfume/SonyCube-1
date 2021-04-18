using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DZFire_Enm2 : MonoBehaviour
{
    public GameObject dangerZF;
    public float dZonePosition = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        GameObject dZ = Instantiate(dangerZF);
        dZ.transform.position = new Vector3(transform.position.x, dZonePosition, transform.position.z);
    }
}
