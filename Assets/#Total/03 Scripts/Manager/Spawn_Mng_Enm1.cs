using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Mng_Enm1 : MonoBehaviour
{
    public GameObject EnemyFactoryX; //X팩토리에 소환될것 넣기
    public GameObject EnemyFactoryZ; //Z팩토리에 소환될것 넣기
    float SpawnSpeed; //생성속도
    float currentTime; //흐르는시간
    int ran; //팩토리에서 소환될 랜덤 위치
    // Start is called before the first frame update
    void Start()
    {
        Manage_Enm1.Enm1SpawnEnable = true;
        SpawnSpeed = Random.Range(1f, 4f); //초기 랜덤지정
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if (SpawnSpeed < currentTime)
        {
            ran = Random.Range(0, 17);

            Spawn();
            currentTime = 0; //시간 초기화
            SpawnSpeed = Random.Range(6f, 12f); //랜덤한 시간에 생성
            Manage_Enm1.Enm1Cnt++; //Enemy 카운트 증가
            //print(Manage_Enm1.Enm1Cnt); //소환 수량 확인
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
