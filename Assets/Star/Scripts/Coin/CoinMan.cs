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

    public List<GameObject> coinFool = new List<GameObject>();
    public int poolSize = 3;


    private void Start()
    {
        spawnSpeed = Random.Range(ranTimeMin, ranTimeMax);

        for (int i = 0; i < poolSize; i++)
        {
            ran = Random.Range(0, childLength);
            GameObject coin = Spawn();
            ResetPosition(coin);
;
            coin.SetActive(false);
        }
    }
    void Update()
    {
        if (GameManager.instance.gState != GameManager.GameState.Play)
        { return; }

        currentTime += Time.deltaTime;

        if (currentTime > spawnSpeed)
        {
            if (coinFool.Count > 0)
            {
                coinFool[0].SetActive(true);
                coinFool.Remove(coinFool[0]);
            }
             currentTime = 0;
            spawnSpeed = Random.Range(ranTimeMin, ranTimeMax);
          
        }
        
    } 
    GameObject Spawn()
    {
        GameObject coin = null;
        if (ran >= ranCnt)
        {
            coin = Instantiate(coinFactoryX);
            coin.GetComponent<Coin_OnTrigger>().rand = 18;            
        }
        else
        {
            coin = Instantiate(coinFactoryZ);
            coin.GetComponent<Coin_OnTrigger>().rand = 9;
        }
        return coin;
    }

    public void ResetPosition(GameObject go)
    {

        coinFool.Add(go);
        int rand = go.GetComponent<Enemy2>().rand;
        int ran;
        if(rand == 9)
        {
            ran = Random.Range(0, 9);
            go.transform.position = transform.GetChild(ran).position;
        }
        else
        {
            ran = Random.Range(9, 18);
            go.transform.position = transform.GetChild(ran).position;

        }
    }

}