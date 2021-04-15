using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlockEnemy : MonoBehaviour
{
    public GameObject EnemyFactory;
    float SpawnSpeed; //생성속도
    float currentTime; //흐르는시간
    // Start is called before the first frame update
    void Start()
    {
        EnemyManagement.Enm1SpawnEnable = true;
        SpawnSpeed = Random.Range(2f, 16f); //초기 랜덤지정
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if (SpawnSpeed < currentTime && EnemyManagement.Enm1SpawnEnable)
        {
            Spawn();
            currentTime = 0;
            //시간 초기화
            SpawnSpeed = Random.Range(10f, 24f);
            //랜덤한 시간에 생성

            EnemyManagement.Enm1Cnt++;
            print(EnemyManagement.Enm1Cnt);
            //Enemy 카운트 증가
        }
    }
    void Spawn()
    {
        GameObject enemy = Instantiate(EnemyFactory);
        enemy.transform.position = transform.position;
    }
}
