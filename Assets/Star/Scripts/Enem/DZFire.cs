using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DZFire : MonoBehaviour
{
    public GameObject dangerZF;
    public float dZonePosition = 0.5f;
    // Start is called before the first frame update
    void OnEnable()
    {
        if (GameManager.instance.gState != GameManager.GameState.Play)
        { return; }
        GameObject dZ = Instantiate(dangerZF);
        dZ.transform.position = new Vector3(transform.position.x, dZonePosition, transform.position.z);
    }
}
