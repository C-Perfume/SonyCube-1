using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerR : MonoBehaviour
{
    public float speed = 10;
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
        Vector3 dirV = Vector3.up * v;   
       
        //Ű�� ������ ���� �޶�����.
        if (Input.GetButtonDown("Horizontal"))
        {
            // ȸ���Ѵ�.
            transform.Rotate(dirH * speed * Time.deltaTime, Space.World);
        }
        else if (Input.GetButtonDown("Vertical"))
        {
            transform.Rotate(dirV * speed * Time.deltaTime, Space.World);
        }
    }
}
