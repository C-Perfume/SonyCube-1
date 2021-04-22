using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Man : MonoBehaviour
{
    public GameObject EnemyFactoryX;
    public GameObject EnemyFactoryZ;
    float spawnSpeed;
    public int ranTimeMinU = 3;
    public int ranTimeMaxU = 8;
    public int ranTimeMin = 5;
    public int ranTimeMax = 10;
    float currentTime;
    public int ranCnt = 9;
    int ran;
    public int childLength = 0;
    // Start is called before the first frame update

    void Start()
    {
        spawnSpeed = Random.Range(ranTimeMin, ranTimeMax);
    }
    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if (spawnSpeed < currentTime)
        {
            ran = Random.Range(0, childLength);
            Spawn();
            currentTime = 0;
            //시간 초기화
            spawnSpeed = Random.Range(ranTimeMinU, ranTimeMaxU);
            //랜덤한 시간에 생성

        }
    }
    void Spawn()
    {
        if (ran >= ranCnt)
        {
            GameObject enemy = Instantiate(EnemyFactoryX);
            enemy.transform.position = transform.GetChild(ran).position;
        }
        else
        {
            GameObject enemy = Instantiate(EnemyFactoryZ);
            enemy.transform.position = transform.GetChild(ran).position;
        }

    }
}