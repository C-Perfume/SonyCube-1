using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1share : MonoBehaviour
{
    public int rand;
    public void Deactive()
    {
        gameObject.SetActive(false);
        GameObject.Find("E1 Spawner").GetComponent<SpawnBlockEnemy>().ResetPosition(gameObject);
    }
}
