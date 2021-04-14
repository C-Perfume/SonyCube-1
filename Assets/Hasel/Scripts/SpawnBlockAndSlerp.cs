using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlockAndSlerp : MonoBehaviour
{
    public GameObject EnemyFactory;
    public GameObject targetPosition;
    private float SpawnSpeed; //���� �ӵ�
    float currentTime; //�帣�� �ð�

    // Start is called before the first frame update
    void Start()
    {
        SpawnSpeed = Random.Range(6f, 20f); //������ �����ӵ� ����
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
            Slerping();

            SpawnSpeed = Random.Range(6f, 20f);
            //������ �ð��� ����
        }
    }
    void Spawn()
    {
        GameObject enemy = Instantiate(EnemyFactory); //������ ���丮���� ����
        enemy.transform.position = transform.position;
    }
    void Slerping()
    {
        transform.position = Vector3.Lerp(gameObject.transform.position, targetPosition.transform.position, 1f);
    }
}
