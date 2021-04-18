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
            //�ð� �ʱ�ȭ
            SpawnSpeed = Random.Range(6f, 20f);
            //������ �ð��� ����
        }
    }
    void Spawn()
    {
        GameObject enemy = Instantiate(EnemyFactory);
        enemy.transform.position = transform.position;
    }   
}