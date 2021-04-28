using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BGFadein : MonoBehaviour
{
    public GameObject bg;
    public Image black;
    Color color;
    public float waitTime = 32;
    public float speed = 3;
    //bool next = true;
    float currT = 0;
      
    void Start()
    {
        color = black.color;
        color.a = 0;
        black.color = color;
        bg.SetActive(false);
        StartCoroutine(ActiveBG());
       
    }
    private void Update()
    {
         Fadein();
    }
    IEnumerator ActiveBG()
    {
        yield return new WaitForSeconds(waitTime);
        bg.SetActive(true);
        
    }
    void Fadein()
    {
        currT += Time.deltaTime;
        if (bg.activeSelf && currT >= waitTime)
        {
            color.a += 0.01f * speed * Time.deltaTime;
            black.color = color;
            if (color.a >= 0.99) { GameObject.Find("Black").GetComponent<IntroText>().SkipBtn(); currT = 0; };
        }
    }
}
