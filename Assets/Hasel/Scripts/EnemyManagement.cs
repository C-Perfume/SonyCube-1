using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyManagement : MonoBehaviour
{
    public static EnemyManagement instance;
    //��ȯ�� ���� ����
    public static int Enm1Cnt;
    //���� �� �ִ� ��ȯ ����
    public static int Enm1max=3;
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
    //    //1. ã�� ScoreManager ������Ʈ(Ŭ����) currScore ����
    //    Enm1Cnt++;
    //} 
}
