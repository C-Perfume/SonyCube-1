using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3Man : MonoBehaviour
{
    public GameObject enemyFactory;

    float spawnSpeed;
    public int ranTimeMin = 5;
    public int ranTimeMax = 10;
    float currentTime = 0;
    int ran;
    public int childLength = 0;

    public List<GameObject> enemyFool = new List<GameObject>();
    public List<GameObject> activenemy = new List<GameObject>();
    public int poolSize = 1;


    private void Start()
    {
        spawnSpeed = Random.Range(ranTimeMin, ranTimeMax);

        for (int i = 0; i < poolSize; i++)
        {
            ran = Random.Range(0, childLength);
            GameObject enemy = Spawn();
            ResetPosition(enemy);
;           enemy.SetActive(false);
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
        enemy = Instantiate(enemyFactory);
        return enemy;
    }

    public void ResetPosition(GameObject go)
    {
        activenemy.Remove(go);
        enemyFool.Add(go);
        int ran = Random.Range(0, childLength);
        go.transform.position = transform.GetChild(ran).position;
    }

    public void AllDeactive()
    {
        Enemy3 enemy;
        for(int i = 0; i < activenemy.Count; i++)
        {
            enemy = activenemy[i].GetComponent<Enemy3>();
            enemy.Deactive();
        }
    }
}