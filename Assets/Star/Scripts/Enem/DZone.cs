using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DZone : MonoBehaviour
{
    public float destroyT = 0;
    public float scaleT = 0.8f; 
    public float scaleSize = 1f;
    bool scale = true;
    float scaleCut = 0;
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, destroyT);
    }

    // Update is called once per frame
    void Update()
    {
         
        //�������� 1�ʸ��� 0���� ?�� ���ϱ�
        if (scale && scaleCut < 1)
        {
            transform.localScale += new Vector3(scaleSize, scaleSize, scaleSize) * Time.deltaTime * scaleT;
            if (transform.localScale.z >= scaleSize)
            {
                transform.localScale = new Vector3(scaleSize, scaleSize, scaleSize);
                scale = false;
                scaleCut++;
            }

        }
        
    }
}
