using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerM : MonoBehaviour
{

    public float speed = 2;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        //������� �Է��� �޾�
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        //�����¿� ��������
        Vector3 dirH = Vector3.right * h;
        Vector3 dirV = Vector3.forward * v;
        

        //1�� ���� ���ؾ� �ϴµ�..
        //Ű�� ������ ���� �޶�����.
        if (Input.GetButtonDown("Horizontal"))
        {
            //����̵�
            transform.position += dirH * speed * Time.deltaTime;
        }
        else if (Input.GetButtonDown("Vertical"))
        {
            transform.position += dirV * speed * Time.deltaTime;
        }
      
    }
}
