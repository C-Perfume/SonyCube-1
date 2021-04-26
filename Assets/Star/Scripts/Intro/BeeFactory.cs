using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeFactory : MonoBehaviour
{
    float currT = 0;
    public float waitT = 18;
    public GameObject beeFactory;

    // Update is called once per frame
    void Update()
    {
        currT += Time.deltaTime;
        if (currT >= waitT)
        {
            GameObject bee = Instantiate(beeFactory);
            bee.transform.position = new Vector3(-28.23f, 2.07f, -31.61f);
            currT = 0;
        }
    }
}
