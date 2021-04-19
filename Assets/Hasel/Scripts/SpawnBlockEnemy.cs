using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlockEnemy : MonoBehaviour
{
    public GameObject EnemyFactoryX;
    public GameObject EnemyFactoryZ;
    float SpawnSpeed; //�����ӵ�
    float currentTime; //�帣�½ð�
    int ran;
    void Start()
    {
        EnemyManagement.Enm1SpawnEnable = true;
        SpawnSpeed = Random.Range(1f, 4f); //�ʱ� ��������
    }

    void Update()
    {
        currentTime += Time.deltaTime;
        if (SpawnSpeed < currentTime)
        {
            ran = Random.Range(0, 17);

            Spawn();
            currentTime = 0; //������ �ð��� ����
            SpawnSpeed = Random.Range(6f, 12f); //������ �ð��� ����
            EnemyManagement.Enm1Cnt++; //Enemy ī��Ʈ ����            
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
