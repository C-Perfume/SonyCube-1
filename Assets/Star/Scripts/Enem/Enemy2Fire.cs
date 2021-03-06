using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Fire : MonoBehaviour
{
    float realTime;
    public float creatTime = 0.5f;
    public GameObject laserF;
        int laserCnt=0;
    bool laserA = true;
    //float spawnSpd = 0;
    public GameObject dangerZF;
    public float dZonePosition = -0.3f;
    // Start is called before the first frame update
 
    void OnEnable()
    {
        if (GameManager.instance.gState != GameManager.GameState.Play)
        { return; }
        GameObject dZ = Instantiate(dangerZF); 
                dZ.transform.position = new Vector3(transform.position.x, dZonePosition, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
               realTime += Time.deltaTime;

        if (laserA)
        {
            if (creatTime < realTime)
            {
                GameObject laser = Instantiate(laserF);
                laser.transform.position = transform.position;
                realTime = 0;
                laserCnt++;
                if (laserCnt >= 1)
                { laserA = false; }
            }
        }
    }

    private void OnDisable()
    {
        laserCnt = 0;
        laserA = true;
        realTime = 0;
    }
}
