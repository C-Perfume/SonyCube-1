using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObRotate : MonoBehaviour
{   //ȸ����

    float rotY;
    public float rot1;

    // ȸ�����ɿ���
    public bool useH = false;

    //ȸ���ӷ�
    public float rotSpeed = 200;
       void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            float mx = Input.GetAxis("Mouse X");
            if (useH) rotY -= mx * rotSpeed * Time.deltaTime;
            rotY = Mathf.Clamp(rotY, -90, 90);
            transform.localEulerAngles = new Vector3(0, rotY+rot1, 0);
        }
    }
   
}
