using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlockEnemy : MonoBehaviour
{
    public GameObject EnemyFactory;
    public float SpawnSpeed = 13;
    public float MoveSpeed = -4;
    float currentTime;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if (SpawnSpeed < currentTime)
        {
            Spawn();
            Move();
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
    void Move()
    {
        transform.position += transform.up * MoveSpeed * Time.deltaTime;
    }
}
