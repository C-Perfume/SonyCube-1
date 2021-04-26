using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrienttoPathMover : MonoBehaviour
{
    [SerializeField]
    public Transform[] path1;
    public Transform[] path2;
    float dealyT = 1.5f;

    private void Start()
    {
        Move1();
    }

    void OnDrawGizmos()
    {
        iTween.DrawPath(path1);
        iTween.DrawPath(path2);
    }

    void Move1()
    {
        iTween.MoveTo(gameObject, iTween.Hash(
            "path", path1, 
            "time", 5, 
            "delay", dealyT,
            "orienttopath", true, 
            "looktime", .6, 
            "easetype", iTween.EaseType.easeInOutSine,
            "oncomplete", "Move2"
            //,"looptype", iTween.LoopType.loop
            ));
    }
    void Move2()
    {
        iTween.MoveTo(gameObject, iTween.Hash(
            "path", path2,
            "time", 3,
            //"delay", dealyT,
            "orienttopath", true,
            "looktime", .6,
            "easetype", iTween.EaseType.easeInOutSine,
            "oncomplete", "Move1"
            ));
    }

}
