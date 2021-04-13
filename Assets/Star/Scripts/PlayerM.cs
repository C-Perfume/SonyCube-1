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

        if(Input.GetKeyDown(KeyCode.D))
        {        
            transform.position += Vector3.right;            
            transform.eulerAngles = new Vector3(0, 90, 0);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += Vector3.left;

        }

        

        ////사용자의 입력을 받아
        //float h = Input.GetAxis("Horizontal");
        //float v = Input.GetAxis("Vertical");

        ////전후좌우 방향으로
        //Vector3 dirH = Vector3.right * h;
        //Vector3 dirV = Vector3.forward * v;
        

        ////1의 값이 변해야 하는데..
        ////키를 뗄때만 값이 달라진다.
        //if (Input.GetButtonDown("Horizontal"))
        //{
        //    //계속이동
        //    transform.position += dirH * speed * Time.deltaTime;
        //}
        //else if (Input.GetButtonDown("Vertical"))
        //{
        //    transform.position += dirV * speed * Time.deltaTime;
        //}
      
    }
}
