using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    public int speed = 5;
    public float destroyT = 5;
    bool isDrop = true;
    // Start is called before the first frame update
    void Start()
    {
       Destroy(gameObject, destroyT);
        destroyT = Time.deltaTime;
      
    }
    private void Update()
    {
        if(isDrop)
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
            if(transform.position.y <= 1)
            {
                isDrop = false;
                transform.position = new Vector3(transform.position.x, 1, transform.position.z);
            }
        }
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
