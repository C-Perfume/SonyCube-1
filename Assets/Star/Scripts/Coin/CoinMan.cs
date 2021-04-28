using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMan : MonoBehaviour
{
    public GameObject coinFactoryX;
    public GameObject coinFactoryZ;

    float spawnSpeed;
    public int ranTimeMin = 5;
    public int ranTimeMax = 10;
    float currentTime = 0;
    public int ranCnt = 9;
    int ran;
    public int childLength = 0;


    private void Start()
    {
        spawnSpeed = Random.Range(ranTimeMin, ranTimeMax);

    }
    void Update()
    {
        if (GameManager.instance.gState != GameManager.GameState.Play)
        { return; }

        currentTime += Time.deltaTime;

        if (currentTime > spawnSpeed)
        {
            ran = Random.Range(0, childLength);
            Spawn();
            currentTime = 0;
            spawnSpeed = Random.Range(ranTimeMin, ranTimeMax);
          
        }
        
    }
    void Spawn()
    {
         
        if (ran >= ranCnt)
        {
            GameObject coin = Instantiate(coinFactoryX);
            coin.transform.position = transform.GetChild(ran).position;
        }
        else
        {
            GameObject coin = Instantiate(coinFactoryZ);
            coin.transform.position = transform.GetChild(ran).position;
        }
      
    }

}