using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BestCoinMove : MonoBehaviour
{
    RectTransform rt2;

    private void Start()
    {
        rt2 = GetComponent<RectTransform>();
    }
    void Update()
    {
        if (GameManager.instance.gState != GameManager.GameState.Play)
        {
            rt2.anchoredPosition = new Vector2(1200, -410);
        }
        else
        {
            rt2.anchoredPosition = new Vector2(3000, -410);
        }
    }
}
