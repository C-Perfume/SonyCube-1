using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlockEnemy : MonoBehaviour
{
    public GameObject EnemyFactory;
    private float SpawnSpeed; //생성 속도
    float currentTime; //흐르는 시간

    // Start is called before the first frame update
    void Start()
    {
        SpawnSpeed = Random.Range(6f, 20f); //랜덤한 생성속도 설정
    }

    // Update is called once per frame
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
        GameObject enemy = Instantiate(EnemyFactory); //지정된 팩토리에서 생성
        enemy.transform.position = transform.position;
    }
}
