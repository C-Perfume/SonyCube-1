using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlockEnemy : MonoBehaviour
{
    public GameObject EnemyFactory;
    public float SpawnSpeed = 13; //�ʱ� �����ӵ�
    float currentTime;

    // Start is called before the first frame update
    void Start()
    {
        SpawnSpeed = Random.Range(6f, 20f);
    }

    // Update is called once per frame
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
