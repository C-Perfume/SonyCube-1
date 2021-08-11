using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class introBeeM : MonoBehaviour
{

   
    GameObject beeChild;
    public Transform[] beepath;
    public Transform[] beepath2;
    public float findT = 1;

    private void Start()
    {
          Move();
            beeChild = transform.GetChild(2).gameObject;
            beeChild.SetActive(false);
           }

    void OnDrawGizmos()
    {
        iTween.DrawPath(beepath);
        iTween.DrawPath(beepath2);
    }

    void Move()
    {
        iTween.MoveTo(gameObject, iTween.Hash(
            "path", beepath, 
            "time", 3, 
          //  "orienttopath", true, 
            "looktime", .6, 
            "easetype", iTween.EaseType.easeInOutBack,
            "oncomplete", "Move1"
            ));
        
    }

    void Move1()
    {  beeChild.SetActive(true);
        iTween.MoveTo(gameObject, iTween.Hash(
            "delay", findT,
            "path", beepath2,
            "time", 3,
            //"orienttopath", true,
            "looktime", .6
            
            ));
    }
}
