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

    void Start()
    {
        move1 = Enemy3move.StayT;
        StartCoroutine(StayT());
        Invoke("DestroyObject", destroyT);
    }
    void DestroyObject() { Destroy(gameObject); }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("Play") || other.gameObject.name.Contains("Coin"))
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
        target = GameObject.Find("PlayersEmpty");
        if (target != null)
        {
            Vector3 dir = target.transform.position - transform.position;
            //transform.position += dir * Time.deltaTime;

            if (dir.x >= 0 && dir.z >= 0)
            {
                if (dir.x > dir.z)
                {
                    transform.position += Vector3.right;
                    transform.eulerAngles = new Vector3(0, 90, 0);
                }
                else
                {
                    transform.position += Vector3.forward;
                    transform.eulerAngles = new Vector3(0, -180, 0);
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
                    transform.eulerAngles = new Vector3(0, -0, 0);
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
                    transform.eulerAngles = new Vector3(0, -0, 0);
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
                    transform.eulerAngles = new Vector3(0, -180, 0);
                }
            }
        }
        move1 = Enemy3move.Stay;
        StartCoroutine(Stay());
    }
    IEnumerator Stay()
    {
        yield return new WaitForSeconds(1);
        move1 = Enemy3move.Move;
    }

    IEnumerator StayT()
    {
        yield return new WaitForSeconds(stayT);
        move1 = Enemy3move.Move;
    }

}
