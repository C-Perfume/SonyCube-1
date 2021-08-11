using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3 : MonoBehaviour
{
    GameObject target;
    public float destroyT = 10;
    public float stayT = 4;
    public float waitT = 1;
    float currT = 0;
    Vector3 dir;
     Vector3 originDir;
    public int findCnt = 5;
    int i = 0;
    bool istrue = true;
    private void OnEnable()
    {
        StartCoroutine(ActiveFalse());
    }

    IEnumerator ActiveFalse()
    {
        yield return new WaitForSeconds(destroyT);
        Deactive();
    }

    public void Deactive()
    {
        gameObject.SetActive(false);
        GameObject.Find("E3 Spawner").GetComponent<Enemy3Man>().ResetPosition(gameObject);
    }
    private void OnDisable()
    {
        StopCoroutine(ActiveFalse());
    }

    void Start()
    {
        StartCoroutine(StayT());
        target = GameObject.Find("PlayersEmpty");
    }
    IEnumerator StayT()
    {
        yield return new WaitForSeconds(stayT);
    }

    void Update()
    {
        if (GameManager.instance.gState != GameManager.GameState.Play)
        { return; }

        if (transform.position.y > 1)
        { transform.position += Vector3.down * Time.deltaTime; }
        else
        {
            transform.position = new Vector3(transform.position.x, 1, transform.position.z);
            currT += Time.deltaTime;

            if (currT > waitT)
            {
                if (istrue)
                {
                    originDir = target.transform.position - transform.position;
                    originDir.Normalize();
                }
                currT = 0; i++; istrue = false; Move();
                if (i == findCnt)
                {
                    originDir = target.transform.position - transform.position;
                    originDir.Normalize();
                    i = 0; istrue = true;
                }
            }
        }

    }

    void Move()
    {
        if (target != null)
        {
            dir = originDir;
            float dist = Vector3.Distance(transform.position, target.transform.position);
            //transform.position += dir * Time.deltaTime;

            if (dist <= 0.1) { transform.position = target.transform.position; }
            else if (dir.x >= 0 && dir.z >= 0)
            {

                if (dir.x > dir.z)
                {
                    transform.position += Vector3.right;
                    transform.eulerAngles = new Vector3(0, 90, 0);
                }
                else
                {
                    transform.position += Vector3.forward;
                    transform.eulerAngles = new Vector3(0, 0, 0);
                }
            }
            else if (dir.x >= 0 && dir.z < 0)
            {
                if (dir.x > -dir.z)
                {
                    transform.position += Vector3.right;
                    transform.eulerAngles = new Vector3(0, 90, 0);
                }
                else
                {
                    transform.position -= Vector3.forward;
                    transform.eulerAngles = new Vector3(0, -180, 0);
                }
            }
            else if (dir.x < 0 && dir.z < 0)
            {
                if (-dir.x > -dir.z)
                {
                    transform.position -= Vector3.right;
                    transform.eulerAngles = new Vector3(0, -90, 0);
                }
                else
                {
                    transform.position -= Vector3.forward;
                    transform.eulerAngles = new Vector3(0, -180, 0);
                }
            }
            else //if (dir.x < 0 && dir.z >= 0)
            {
                if (-dir.x > dir.z)
                {
                    transform.position -= Vector3.right;
                    transform.eulerAngles = new Vector3(0, -90, 0);
                }
                else
                {
                    transform.position += Vector3.forward;
                    transform.eulerAngles = new Vector3(0, -0, 0);
                }
            }
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("Las"))
        {
            currT = 0;
            Deactive();
        }
    }
}