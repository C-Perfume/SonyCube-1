using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyManagement : MonoBehaviour
{
    public static EnemyManagement instance;
   
    public static int Enm1Cnt; //��ȯ�� ���� ����
    public static int Enm1max=2; //���� �� �ִ� ��ȯ ����
    public static bool Enm1SpawnEnable; //��ȯ ���ɿ���

    void Update()
    {
        if (Enm1Cnt < Enm1max) Enm1SpawnEnable = true;
        if (Enm1Cnt >= Enm1max) Enm1SpawnEnable = false;
    }
}
