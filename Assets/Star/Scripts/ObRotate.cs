using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObRotate : MonoBehaviour
{   //회전값

    float rotY;
    public float rot1;

    // 회전가능여부
    public bool useH = false;

    //회전속력
    public float rotSpeed = 200;
       void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            float mx = Input.GetAxis("Mouse X");
            if (useH) rotY += mx * rotSpeed * Time.deltaTime;
            rotY = Mathf.Clamp(rotY, -90, 90);
            transform.localEulerAngles = new Vector3(0, rotY+rot1, 0);
        }
    }
   
}
