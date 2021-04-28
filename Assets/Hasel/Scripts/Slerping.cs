using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slerping : MonoBehaviour
{
    public GameObject Factory;
    public GameObject Target;
    // Update is called once per frame
    void Start()
    {
        Spawn();

    }
    void Update()
    {
        transform.position = Vector3.Slerp(gameObject.transform.position, Target.transform.position, 1f);
    }
    void Spawn()
    {
        GameObject enemy = Instantiate(Factory); //지정된 팩토리에서 생성
        enemy.transform.position = transform.position;
    }
}
