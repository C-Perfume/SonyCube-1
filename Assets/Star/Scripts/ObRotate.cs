using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObRotate : MonoBehaviour
{   //회전값
    float rotX;
    float rotY;

    // 회전가능여부
    public bool useV = false;
    public bool useH = false;

    //회전속력
    public float rotSpeed = 200;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        //마우스의 (움직임값)입력을 받아
        float mx = Input.GetAxis("Mouse X");
        float my = Input.GetAxis("Mouse Y");
        //print(mx +", "+ my);

        //회전각도 누적 //회전방향 선택
        if (useV) rotX += -my * rotSpeed * Time.deltaTime;
        if (useH) rotY += mx * rotSpeed * Time.deltaTime;
        
        //Vector3 dir = new Vector3(-my, mx, 0);
        rotX = Mathf.Clamp(rotX, -90, 90); // 최소 최대값 보정하는 변수
        // if (rotX >= 90) rotX = 90;
        // if (rotX <= -90) rotX = -90;
        // new Vector3(my, mx, 0) = Vector3.up * mx; 그냥 vector3로 하면 값을 변경할 때마다 코드가 하나씩 늘어나지만 new를 쓰면 두개 한줄로 적을 수 있다.
        // 사람이 90도 이상 뒤로 넘어갈 일이 없으니 회전각도에 제한을 두자
        
       

        //받아온 값으로 물체를 회전하자
        transform.localEulerAngles = new Vector3(rotX, rotY, 0);
        
        //// rotation은 vector가 아니라서 eulerAngles사용
        //// transform.position += Vector3.right * Time.deltaTime;
        //Vector3 rot = transform.eulerAngles;
        //if (rot.x >= -90) rot.x = -90;
        //if (rot.x <= 90) rot.x = 90;
        //transform.eulerAngles = rot; // 조정 값을 갱신하는 코드

    }
}
