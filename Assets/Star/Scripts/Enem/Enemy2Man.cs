using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Man : MonoBehaviour
{
    public GameObject enemyFactoryX;
    public GameObject enemyFactoryZ;

    float spawnSpeed;
    public int ranTimeMin = 5;
    public int ranTimeMax = 10;
    float currentTime = 0;
    public int ranCnt = 9;
    int ran;
    public int childLength = 0;

    public List<GameObject> enemyFool = new List<GameObject>();
    public List<GameObject> activenemy = new List<GameObject>();
    public int poolSize = 3;


    private void Start()
    {
        spawnSpeed = Random.Range(ranTimeMin, ranTimeMax);

        for (int i = 0; i < poolSize; i++)
        {
            ran = Random.Range(0, childLength);
            GameObject enemy = Spawn();
            ResetPosition(enemy);
;          
            enemy.SetActive(false);
        }
    }
    void Update()
    {
        if (GameManager.instance.gState != GameManager.GameState.Play)
        { return; }

        currentTime += Time.deltaTime;

        if (currentTime > spawnSpeed)
        {
            if (enemyFool.Count > 0)
            {
                enemyFool[0].SetActive(true);
                activenemy.Add(enemyFool[0]);
                enemyFool.Remove(enemyFool[0]);
            }
            
             currentTime = 0;
            spawnSpeed = Random.Range(ranTimeMin, ranTimeMax);
          
        }
        
    } 
    GameObject Spawn()
    {
        GameObject enemy = null;
        if (ran >= ranCnt)
        {
            enemy = Instantiate(enemyFactoryX);
            enemy.GetComponent<Enemy2>().rand = 18;            
        }
        else
        {
            enemy = Instantiate(enemyFactoryZ);
            enemy.GetComponent<Enemy2>().rand = 9;
        }
        return enemy;
    }

    public void ResetPosition(GameObject go)
    {
        activenemy.Remove(go);
        enemyFool.Add(go);
        int rand = go.GetComponent<Enemy2>().rand;
        int ran;
        if(rand == 9)
        {
            ran = Random.Range(0, 9);
            go.transform.position = transform.GetChild(ran).position;
        }
        else
        {
            ran = Random.Range(9, 18);
            go.transform.position = transform.GetChild(ran).position;

        }
    }

    public void AllDeactive()
    {
        Enemy2 enemy;
        for(int i = 0; i < activenemy.Count; i++)
        {
            enemy = activenemy[i].GetComponent<Enemy2>();
            enemy.Deactive();
        }
    }
}