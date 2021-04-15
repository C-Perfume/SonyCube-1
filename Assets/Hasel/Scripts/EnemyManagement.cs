using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyManagement : MonoBehaviour
{
    public static EnemyManagement instance;
    //소환된 적의 수량
    public static int Enm1Cnt;
    //지정 할 최대 소환 수량
    public static int Enm1max=2;
    public static bool Enm1SpawnEnable;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        
    }
    void Update()
    {
        //Debug.Log(Enm1SpawnEnable);
        if (Enm1Cnt < Enm1max) Enm1SpawnEnable = true;
        if (Enm1Cnt >= Enm1max) Enm1SpawnEnable = false;
        //Debug.Log(Enm1Cnt);
        //Debug.Log(Enm1max);
    }

    //public void AddEnm1Cnt(int addEnm1Cnt)
    //{
    //    //1. 찾은 ScoreManager 컴포넌트(클래스) currScore 증가
    //    Enm1Cnt++;
    //} 
}
