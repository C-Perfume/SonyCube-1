using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroText : MonoBehaviour
{
    public Image img;
    Color color;
    public int changeSpd;
    float currT;
    public float changeT = 4.5f;
    public GameObject[] targets;
    int next = 0;
    
    private void Start()
    {
        color = img.color;
    }
    void Update()
    {
        if (next == 0)
        {
            iTween.MoveTo(targets[0].gameObject,
                    iTween.Hash(
                        "position", new Vector3(-1234 + 1280, 442 + 720, 0),
                        "Time", 1,
                        "easetype", iTween.EaseType.easeOutBack
                         ));

            iTween.MoveTo(targets[1].gameObject,
                      iTween.Hash(
                          "position", new Vector3(-294.9996f + 1280, 166.9997f + 720, 0),
                          "Time", 1));

            iTween.MoveTo(targets[2].gameObject,
                     iTween.Hash(
                        "position", new Vector3(254.9993f + 1280, -192.0996f + 720, 0),
                         "Time", 1));

            iTween.MoveTo(targets[3].gameObject,
                    iTween.Hash(
                        "delay", 1,
                        "position", new Vector3(1926 + 1280, -622 + 720, 0),
                        "Time", 1,
                        "easetype", iTween.EaseType.easeOutBack
                        )); ;

            for (int i = 1; i <= 2; i++)
            {
                iTween.ScaleTo(targets[i].gameObject,
                       iTween.Hash(
                           "delay", 1 + i,
                           "scale", new Vector3(1, 1, 1),
                           "Time", 1
                           ));
            }
            next++;
        }
        if (next == 1)
        {
            for (int i = 0; i <= 1; i++)
            {
                iTween.MoveTo(targets[i].gameObject,
                       iTween.Hash(
                           "delay", 5+(i*0.3),
                           "position", new Vector3(-3749+1280, 1116+720),
                           "Time", 3
                           ));
            }
            iTween.MoveTo(targets[2].gameObject,
                         iTween.Hash(
                             "delay", 5.3,
                             "position", new Vector3(4166 + 1280, -1223 + 720),
                             "Time", 3
                             ));
            iTween.MoveTo(targets[3].gameObject,
                       iTween.Hash(
                           "delay", 5,
                           "position", new Vector3(4166 + 1280, -1223 + 720),
                           "Time", 3
                           )); 
            
            next++;
           
        }
        if (next == 2)
        { currT += Time.deltaTime;
            if (currT >= changeT)
            {
                color.a -= 0.01f * changeSpd * Time.deltaTime;
                if (color.a <= 0.7) { color.a -= 0.01f * changeSpd*2 * Time.deltaTime; }
                if (color.a <= 0.3) { color.a = 0; }
                img.color = color;
             }
            
        }

    }
}
