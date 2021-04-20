using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public float speed = 10;
    public float destroyS = 7;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, destroyS);
    }

    // Update is called once per frame
    void Update()
    {
       transform.Translate(Vector3.back * speed * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }

}
