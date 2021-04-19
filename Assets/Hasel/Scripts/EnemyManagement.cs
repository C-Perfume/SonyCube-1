using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyManagement : MonoBehaviour
{
    public static EnemyManagement instance;
   
    public static int Enm1Cnt; //소환된 적의 수량
    public static int Enm1max=2; //지정 할 최대 소환 수량
    public static bool Enm1SpawnEnable; //소환 가능여부

    void Update()
    {
        if (Enm1Cnt < Enm1max) Enm1SpawnEnable = true;
        if (Enm1Cnt >= Enm1max) Enm1SpawnEnable = false;
    }
}
