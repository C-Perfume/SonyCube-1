using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3 : MonoBehaviour
{
    enum Enemy3move
    {
        Stay,
        Move,
        StayT
    }
    Enemy3move move1;

    GameObject target;
    public float destroyT = 10;
    public float stayT = 4;
    int i = 0;
    Vector3 dir;
    Vector3 originDir;
    public int findCnt = 5;
    void Start()
    {
       
        move1 = Enemy3move.StayT;
        StartCoroutine(StayT());
        Invoke("DestroyObject", destroyT); 
        target = GameObject.Find("PlayersEmpty");
        originDir = target.transform.position - transform.position;
        originDir.Normalize();
    }
    void DestroyObject() { Destroy(gameObject); }
    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.name.Contains("Ene"))
        {
            Destroy(other.gameObject);
        }
    }
    void Update()
    {
        if (transform.position.y > 1)
        { transform.position += Vector3.down * Time.deltaTime; }
        else
        {
            transform.position = new Vector3(transform.position.x, 1, transform.position.z);
            switch (move1)
            {
                case Enemy3move.Move:
                    Move();
                    break;
                case Enemy3move.Stay:
                    Stay();
                    break;
                case Enemy3move.StayT:
                    StayT();
                    break;
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
        move1 = Enemy3move.Stay;
        StartCoroutine(Stay());
    }
    IEnumerator Stay()
    {
        yield return new WaitForSeconds(1);
        i++;
        move1 = Enemy3move.Move;
        if (i == findCnt)
        {
            originDir = target.transform.position - transform.position;
            originDir.Normalize();
            i = 0;
        }
        
    }

    IEnumerator StayT()
    {
        yield return new WaitForSeconds(stayT);
        move1 = Enemy3move.Move;
    }

}
