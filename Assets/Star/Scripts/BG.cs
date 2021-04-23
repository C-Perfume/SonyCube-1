using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG : MonoBehaviour
{
    public float speed = 5;

    void Update()
    {
        MeshRenderer mr = GetComponent<MeshRenderer>();
        Material mat = mr.material;
        mat.mainTextureOffset += Vector2.right * speed * Time.deltaTime;
    }
}
