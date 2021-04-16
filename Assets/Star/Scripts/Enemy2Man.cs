using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Man : MonoBehaviour
{
    public GameObject EnemyFactoryX;
    public GameObject EnemyFactoryZ;
    float SpawnSpeed;
    float currentTime;
    int ran;
    // Start is called before the first frame update
  

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if (SpawnSpeed < currentTime)
        {
            ran = Random.Range(0, 17);
            Spawn();
            currentTime = 0;
            //시간 초기화
            SpawnSpeed = Random.Range(3, 8);
            //랜덤한 시간에 생성

        }
    }
    void Spawn()
    {
        if (ran >= 9)
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