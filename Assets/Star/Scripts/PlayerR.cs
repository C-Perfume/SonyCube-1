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
        //사용자의 입력을 받아
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        //전후좌우 방향으로
        Vector3 dirH = Vector3.right * h;
        Vector3 dirV = Vector3.up * v;   
       
        //키를 뗄때만 값이 달라진다.
        if (Input.GetButtonDown("Horizontal"))
        {
            // 회전한다.
            transform.Rotate(dirH * speed * Time.deltaTime, Space.World);
        }
        else if (Input.GetButtonDown("Vertical"))
        {
            transform.Rotate(dirV * speed * Time.deltaTime, Space.World);
        }
    }
}
