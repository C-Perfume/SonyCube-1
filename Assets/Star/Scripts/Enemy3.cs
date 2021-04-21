using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3 : MonoBehaviour
{
    enum Enemy3move
    {
        Stay,
        Move
    }
    Enemy3move move1;

    GameObject target;
    public float destroyT = 10;

    void Start()
    {
        move1 = Enemy3move.Move;
        Invoke("DestroyObject", destroyT);    
    }
    void DestroyObject() { Destroy(gameObject); }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("Play")|| other.gameObject.name.Contains("Coin"))
        {
            Destroy(other.gameObject);
        }
    }
    void Update()
    {
          
        if(transform.position.y > 1) 
        { transform.position += Vector3.down*Time.deltaTime; } 
            else {
            switch (move1)
            {
                case Enemy3move.Move:
                    Move();
                    break;
                case Enemy3move.Stay:
                    Stay();
                    break;
            }
        }
    }
   
    void Move()
    {
        target = GameObject.Find("PlayersEmpty");
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
        { if (dir.x > -dir.z)
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
        { if (-dir.x > -dir.z) 
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
        { if (-dir.x > dir.z) 
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
   move1 = Enemy3move.Stay;
        StartCoroutine(Stay());
        print("moving "+ dir);
    }
    IEnumerator Stay()
    {
        yield return new WaitForSeconds(1);
        move1 = Enemy3move.Move;
        print("wait");
    }

}
