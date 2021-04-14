using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerM : MonoBehaviour
{
    public float stopTime = 0.8f;
    float currTime;
    public float stayTime = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        currTime = Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (stopTime > currTime)
        {
            bool d = Input.GetKeyDown(KeyCode.D);
            bool a = Input.GetKeyDown(KeyCode.A);
            bool s = Input.GetKeyDown(KeyCode.S);
            bool w = Input.GetKeyDown(KeyCode.W);
            if (d)
            {
                transform.position += Vector3.right;
                transform.eulerAngles = new Vector3(0, 90, 0);
                if (transform.position.x == -4)
                { d = false; }
            }

            if (a)
            {
                transform.position += Vector3.left;
                transform.eulerAngles = new Vector3(0, -90, 0);
                if (transform.position.x == 4)
                { a = false; }
            }

            if (s)
            {
                transform.position += Vector3.back;
                transform.eulerAngles = new Vector3(0, -180, 0);
                if (transform.position.z == -4)
                { w = false; }
            }

            if (w)
            {
                transform.position += Vector3.forward;
                transform.eulerAngles = new Vector3(0, -0, 0);
                if (transform.position.z == 4)
                { s = false;}
            }

            
        }
       currTime = 0;
        
      
    }
}
