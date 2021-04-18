using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enm1_Move_Z : MonoBehaviour
{
    float currTime = 0;
    bool movable = true; //��� ���߱� Ȯ��

    public float time = 1f; //�̵��ð�
    public GameObject rotation; //������ ������Ʈ ����
    public float stayTime = 1f; //���ߴ� �ð�
    int moveCnt; //������ �̵��ϴ� ĭ �Ÿ� Ȯ��

    float deathtime1 = 0; //�״µ� ���� �帣�� �ð�
    public float deathtime2 = 20; //���� �ð�

    void Update()
    {
        if (movable)
        {
            currTime += Time.deltaTime; //�ð��� �帧
            transform.position -= transform.forward * Time.deltaTime * (1 / time); //������ �̵�
            rotation.transform.Rotate(-90 * Time.deltaTime * (1 / time), 0, 0); //������ ������

            if (moveCnt >= 10) transform.position -= transform.up * Time.deltaTime; //n������ ������

            else if (currTime > time) //�����鼭 �̵��� � �ʰ��� ���̳ʽ� ����
            {
                float f = currTime - time; //� �ʰ��� ���

                movable = false;
                currTime = 0;
                moveCnt++;
                rotation.transform.Rotate(90 * f * (1 / time), 0, 0); //ȸ�� �ʰ��� ����
                transform.position += transform.forward * f * (1 / time); //�̵� �ʰ��� ����
            }
        }
        else 
        {
            currTime += Time.deltaTime;

            if (currTime > stayTime)
            {
                movable = true;
                currTime = 0;
            }
        }
        deathtime1 += Time.deltaTime;
        if (deathtime1 > deathtime2)
        {
            deathtime1 = 0;
            Destroy(gameObject);
            Manage_Enm1.Enm1Cnt = 0;
        }
    }
}
