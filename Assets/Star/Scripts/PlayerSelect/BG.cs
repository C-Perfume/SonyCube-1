using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG : MonoBehaviour
{
    public float speed = 0.1f;
    Material mt;
   
   
    void Update()
    {
        mt = gameObject.transform.GetComponent<MeshRenderer>().material;
        mt.mainTextureOffset += Vector2.right* speed * Time.deltaTime;
      }
}
