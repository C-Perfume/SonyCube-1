using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enm1_Move_X : MonoBehaviour
{
    float currTime = 0;
    bool movable = true; //잠깐 멈추기 확인

    public float time = 1f; //이동시간
    public GameObject rotation; //구르는 오브젝트 지정
    public float stayTime = 1f; //멈추는 시간
    int moveCnt; //굴러서 이동하는 칸 거리 확인

    float deathtime1 = 0; //죽는데 까지 흐르는 시간
    public float deathtime2 = 20; //죽을 시간

    void Update()
    {
        if (movable)
        {
            currTime += Time.deltaTime; //시간의 흐름
            transform.position += transform.right * Time.deltaTime * (1 / time); //앞으로 이동
            rotation.transform.Rotate(0, 0, -90 * Time.deltaTime * (1 / time)); //앞으로 구르기

            if (moveCnt >= 10) transform.position -= transform.up * Time.deltaTime;//n번까지 구를것

            else if (currTime > time) //구르면서 이동한 운동 초과량 마이너스 보정
            {
                float f = currTime - time; //운동 초과량 계산

                movable = false;
                currTime = 0;
                moveCnt++;
                rotation.transform.Rotate(0, 0, 90 * f * (1 / time)); //회전 초과량 보정
                transform.position -= transform.right * f * (1 / time); //이동 초과량 보정
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
