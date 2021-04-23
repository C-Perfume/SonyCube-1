using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCoinR : MonoBehaviour
{
    public int dropSpd = 2;
    public int spinSpd = 2;
    public int stayT = 3;
    public int destroyT = 5;
    bool isDrop = true;
    float currT = 0;
    public GameObject redC;
    void Start()
    {
        Destroy(gameObject, destroyT);
    }
    void Update()
    { if (redC != null) redC.transform.Rotate(0, 90 * spinSpd * Time.deltaTime, 0) ;

        if (isDrop)
        {
            transform.position += Vector3.down * dropSpd * Time.deltaTime;
            if (transform.position.y <= 1)
            {
                isDrop = false;
                transform.position = new Vector3(transform.position.x, 1, transform.position.z);
            }
        }
        currT += Time.deltaTime;

        if (currT >= stayT) transform.position += transform.up * dropSpd * Time.deltaTime;
    
    }
    
}
