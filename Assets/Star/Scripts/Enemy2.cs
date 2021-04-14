using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    public int speed = 10;
    public float destroyT = 5;
    public float stayT = 3;
    float currT=0;
    bool isDrop = true;

    // Start is called before the first frame update
    void Start()
    {  
        
       Destroy(gameObject, destroyT);

    }
    private void Update()
    {
        
        if (isDrop)
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
            if (transform.position.y <= 1)
            {
                isDrop = false;
                transform.position = new Vector3(transform.position.x, 1, transform.position.z);
            }
        } 
        currT += Time.deltaTime;

        if (currT >= stayT) transform.position += transform.up * speed * Time.deltaTime;
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name.Contains("Spawn"))
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.constraints = RigidbodyConstraints.None;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        
    }
}
