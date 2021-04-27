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
    public int rand;

    private void OnEnable()
    {
        StartCoroutine(ActiveFalse());
    }

    private void OnDisable()
    {
        StopAllCoroutines();
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

        //StartCoroutine(ActiveFalse());
    }
    IEnumerator ActiveFalse()
    {
        yield return new WaitForSeconds(destroyT);
        Deactive();
    }

    public void Deactive()
    {
        gameObject.SetActive(false);
        isDrop = true;
        currT = 0;
        GameObject.Find("E2 Spawner").GetComponent<Enemy2Man>().ResetPosition(gameObject);
    }

}
