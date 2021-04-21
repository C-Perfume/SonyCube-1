using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObRotate : MonoBehaviour
{
    //public static int playerNumbers = 0;

    //회전값
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
            if (useH) rotY -= mx * rotSpeed * Time.deltaTime;
            rotY = Mathf.Clamp(rotY, -90, 90);
            transform.localEulerAngles = new Vector3(0, rotY + rot1, 0);


        }


        //for (int i = 0; i < 6; i++)
        //    if(transform.localEulerAngles.y <= 60+(i*-30) || transform.localEulerAngles.y > 30+(i * -30))
        //    { playerNumbers = i; }

        /*
         * if (transform.localEulerAngles.y > 30)
            { playerNumbers = 0; }
            else if (transform.localEulerAngles.y <= 30 || transform.localEulerAngles.y > 0)
            { playerNumbers = 1; }
            else if (transform.localEulerAngles.y <= 0 || transform.localEulerAngles.y > -30)
            { playerNumbers = 2; }
            else if (transform.localEulerAngles.y <= -30 || transform.localEulerAngles.y > -60)
            { playerNumbers = 3; }
            else if (transform.localEulerAngles.y <= -60 || transform.localEulerAngles.y > -90)
            { playerNumbers = 4; }
            else if (transform.localEulerAngles.y <= -90 || transform.localEulerAngles.y > -120)
            { playerNumbers = 5; }
            else if (transform.localEulerAngles.y <= -120 || transform.localEulerAngles.y > -150)
            { playerNumbers = 6; }
        */
    }

}
