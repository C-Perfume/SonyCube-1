using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObRotate : MonoBehaviour
{   //ȸ����
    float rotX;
    float rotY;

    // ȸ�����ɿ���
    public bool useV = false;
    public bool useH = false;

    //ȸ���ӷ�
    public float rotSpeed = 200;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        //���콺�� (�����Ӱ�)�Է��� �޾�
        float mx = Input.GetAxis("Mouse X");
        float my = Input.GetAxis("Mouse Y");
        //print(mx +", "+ my);

        //ȸ������ ���� //ȸ������ ����
        if (useV) rotX += -my * rotSpeed * Time.deltaTime;
        if (useH) rotY += mx * rotSpeed * Time.deltaTime;
        
        //Vector3 dir = new Vector3(-my, mx, 0);
        rotX = Mathf.Clamp(rotX, -90, 90); // �ּ� �ִ밪 �����ϴ� ����
        // if (rotX >= 90) rotX = 90;
        // if (rotX <= -90) rotX = -90;
        // new Vector3(my, mx, 0) = Vector3.up * mx; �׳� vector3�� �ϸ� ���� ������ ������ �ڵ尡 �ϳ��� �þ���� new�� ���� �ΰ� ���ٷ� ���� �� �ִ�.
        // ����� 90�� �̻� �ڷ� �Ѿ ���� ������ ȸ�������� ������ ����
        
       

        //�޾ƿ� ������ ��ü�� ȸ������
        transform.localEulerAngles = new Vector3(rotX, rotY, 0);
        
        //// rotation�� vector�� �ƴ϶� eulerAngles���
        //// transform.position += Vector3.right * Time.deltaTime;
        //Vector3 rot = transform.eulerAngles;
        //if (rot.x >= -90) rot.x = -90;
        //if (rot.x <= 90) rot.x = 90;
        //transform.eulerAngles = rot; // ���� ���� �����ϴ� �ڵ�

    }
}
