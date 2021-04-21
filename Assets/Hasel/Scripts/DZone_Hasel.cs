using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DZone_Hasel : MonoBehaviour
{
    float destroyT = 1f;
    float scaleT = 2f; 
    public float scaleSize = 0.99f;
    bool scale = true;
    float scaleCut = 0;

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
