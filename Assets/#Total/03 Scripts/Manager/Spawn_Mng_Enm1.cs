using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Mng_Enm1 : MonoBehaviour
{
    public GameObject EnemyFactoryX; //X���丮�� ��ȯ�ɰ� �ֱ�
    public GameObject EnemyFactoryZ; //Z���丮�� ��ȯ�ɰ� �ֱ�
    float SpawnSpeed; //�����ӵ�
    float currentTime; //�帣�½ð�
    int ran; //���丮���� ��ȯ�� ���� ��ġ
    // Start is called before the first frame update
    void Start()
    {
        Manage_Enm1.Enm1SpawnEnable = true;
        SpawnSpeed = Random.Range(1f, 4f); //�ʱ� ��������
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if (SpawnSpeed < currentTime)
        {
            ran = Random.Range(0, 17);

            Spawn();
            currentTime = 0; //�ð� �ʱ�ȭ
            SpawnSpeed = Random.Range(6f, 12f); //������ �ð��� ����
            Manage_Enm1.Enm1Cnt++; //Enemy ī��Ʈ ����
            //print(Manage_Enm1.Enm1Cnt); //��ȯ ���� Ȯ��
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
