using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manage_Enm1 : MonoBehaviour
{
    public static Manage_Enm1 instance;
    public static int Enm1Cnt; //��ȯ�� ���� ����
    public int Enm1max=3; //���� �� �ִ� ��ȯ ����
    public static bool Enm1SpawnEnable;

    void Update()
    {
        if (Enm1Cnt < Enm1max) Enm1SpawnEnable = true;
        if (Enm1Cnt >= Enm1max) Enm1SpawnEnable = false;
        //Debug.Log(Enm1Cnt);
    }
}
