using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageBGMove : MonoBehaviour
{
     float currT = 0;
    public int stayT = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currT += Time.deltaTime;
        if (currT >= stayT)
        { shrink(); }
        
    }
    void shrink()
    {
        if (Input.anyKeyDown)
        {
            iTween.ScaleTo(gameObject,
                    iTween.Hash(
                       "scale", new Vector3(19, 13, 1),
                        "time", 1.1f,
                        "easetype", iTween.EaseType.easeOutBounce,
                        "looptype", iTween.LoopType.loop
                         ));
        }
    }
   }
    
