using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Mng_Enm2 : MonoBehaviour
{
    public GameObject EnemyFactory;
    float SpawnSpeed; 
     float currentTime;

    void Start()
    {
        SpawnSpeed = Random.Range(0f, 14f);
    }

    void Update()
    {
        currentTime += Time.deltaTime;
        if (SpawnSpeed < currentTime)
        {
            Spawn();
            currentTime = 0;
            //시간 초기화
            SpawnSpeed = Random.Range(6f, 20f);
            //랜덤한 시간에 생성
        }
    }
    void Spawn()
    {
        GameObject enemy = Instantiate(EnemyFactory);
        enemy.transform.position = transform.position;
    }   
}