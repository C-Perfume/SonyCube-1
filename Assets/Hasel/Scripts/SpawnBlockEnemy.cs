using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlockEnemy : MonoBehaviour
{
    public GameObject EnemyFactory;
    float SpawnSpeed; //�����ӵ�
    float currentTime; //�帣�½ð�
    // Start is called before the first frame update
    void Start()
    {
        EnemyManagement.Enm1SpawnEnable = true;
        SpawnSpeed = Random.Range(2f, 16f); //�ʱ� ��������
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if (SpawnSpeed < currentTime && EnemyManagement.Enm1SpawnEnable)
        {
            Spawn();
            currentTime = 0;
            //�ð� �ʱ�ȭ
            SpawnSpeed = Random.Range(10f, 24f);
            //������ �ð��� ����

            EnemyManagement.Enm1Cnt++;
            print(EnemyManagement.Enm1Cnt);
            //Enemy ī��Ʈ ����
        }
    }
    void Spawn()
    {
        GameObject enemy = Instantiate(EnemyFactory);
        enemy.transform.position = transform.position;
    }
}
