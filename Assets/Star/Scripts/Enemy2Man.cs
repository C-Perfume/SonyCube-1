using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Man : MonoBehaviour
{
    public GameObject enemyFactoryX;
    public GameObject enemyFactoryZ;

    float spawnSpeed;
    public int ranTimeMin = 5;
    public int ranTimeMax = 10;
    float currentTime = 0;
    public int ranCnt = 9;
    int ran;
    public int childLength = 0;

    public List<GameObject> enemyFool = new List<GameObject>();
    public int poolSize = 3;
    GameObject enemy;

    private void OnEnable()
    {
        spawnSpeed = Random.Range(ranTimeMin, ranTimeMax);

        for (int i = 0; i < poolSize; i++)
        {
            ran = Random.Range(0, childLength);
            Spawn();
            enemyFool.Add(enemy);
            enemy.SetActive(false);
        }
    }

    void Update()
    {
        if (GameManager.instance.gState != GameManager.GameState.Play)
        { return; }

        currentTime += Time.deltaTime;

        if (currentTime > spawnSpeed)
        {
            if (enemyFool.Count > 0)
            {
                enemyFool.Remove(enemyFool[0]);
                enemyFool[0].SetActive(true);
               }
             currentTime = 0;
            spawnSpeed = Random.Range(ranTimeMin, ranTimeMax);
          
        }
        
    } 
    void Spawn()
    {
        if (ran >= ranCnt)
        {
            enemy = Instantiate(enemyFactoryX);
            enemy.transform.position = transform.GetChild(ran).position;
        }
        else
        {
            enemy = Instantiate(enemyFactoryZ);
            enemy.transform.position = transform.GetChild(ran).position;
        }

    }
}