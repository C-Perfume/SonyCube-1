using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlockEnemy : MonoBehaviour
{
    public GameObject EnemyFactoryX;
    public GameObject EnemyFactoryZ;
    float SpawnSpeed; //생성속도
    float currentTime; //흐르는시간
    int ran;
    void Start()
    {
        EnemyManagement.Enm1SpawnEnable = true;
        SpawnSpeed = Random.Range(1f, 4f); //초기 랜덤지정
    }

    void Update()
    {
        currentTime += Time.deltaTime;
        if (SpawnSpeed < currentTime)
        {
            ran = Random.Range(0, 17);

            Spawn();
            currentTime = 0; //랜덤한 시간에 생성
            SpawnSpeed = Random.Range(6f, 12f); //랜덤한 시간에 생성
            EnemyManagement.Enm1Cnt++; //Enemy 카운트 증가            
        }
    }
    void Spawn()
    {
        if (ran >= 9)
        {
            GameObject enemy = Instantiate(EnemyFactoryZ);
            enemy.transform.position = transform.GetChild(ran).position;
        }
        if (ran < 9)
        {
            GameObject enemy = Instantiate(EnemyFactoryX);
            enemy.transform.position = transform.GetChild(ran).position;
        }
    }
}
