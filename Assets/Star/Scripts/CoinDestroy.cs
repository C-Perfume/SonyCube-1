using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinDestroy : MonoBehaviour
{
    GameObject[] deadEnemies;
    public static bool dieCoin = false;
    // Start is called before the first frame update
    void Start()
    {
        deadEnemies = GameObject.FindGameObjectsWithTag("CoinDestroy");
    }

    // Update is called once per frame
    void Update()
    {
        if (dieCoin)
        {
            for (int i = 0; i > 50; i++)
            { if (deadEnemies[i] != null) { Destroy(deadEnemies[i]); }
            }
        }
    }
}
