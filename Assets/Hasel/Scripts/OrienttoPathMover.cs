using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrienttoPathMover : MonoBehaviour
{
    [SerializeField]
    Transform[] path;

    private void Start()
    {
        Move();
    }

    void OnDrawGizmos()
    {
        iTween.DrawPath(path);
    }

    void Move()
    {
        iTween.MoveTo(gameObject, iTween.Hash("path", path, "time", 3, "orienttopath", true, "looktime", .6, "easetype", iTween.EaseType.easeInOutSine));
    }
}
