using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroText : MonoBehaviour
{
    public Image img;
    public Text skip;
    Color color;
    Color skColor;
    public int changeSpd;
    float currT;
    public float changeT = 4.5f;
    public GameObject[] targets;
    int next = 0;
    
    private void Start()
    {
        color = img.color;
        skColor = skip.color;
        skColor.a = 0;
        skip.color = skColor;

    }
    void Update()
    {
        if (next == 0)
        {
            iTween.MoveTo(targets[0].gameObject,
                    iTween.Hash(
                        "position", new Vector3(-559+960 , 255+540, 0),
                        "Time", 1,
                        "easetype", iTween.EaseType.easeOutBack
                         ));    

            iTween.MoveTo(targets[1].gameObject,
                      iTween.Hash(
                          "position", new Vector3(-265 + 960, 154 + 540, 0),
                          "Time", 1));

            iTween.MoveTo(targets[2].gameObject,
                     iTween.Hash(
                        "position", new Vector3(289 + 960, -205 + 540, 0),
                         "Time", 1));

            iTween.MoveTo(targets[3].gameObject,
                    iTween.Hash(
                        "delay", 1,
                        "position", new Vector3(607 + 960, -286 + 540, 0),
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
                           "delay", 5 + (i * 0.3),
                           "position", new Vector3(-2731 + 960, 837 + 540),
                           "Time", 3
                           ));
            }
            iTween.MoveTo(targets[2].gameObject,
                         iTween.Hash(
                             "delay", 5.3,
                             "position", new Vector3(2001 + 960, -664 + 540),
                             "Time", 3
                             ));
            iTween.MoveTo(targets[3].gameObject,
                       iTween.Hash(
                           "delay", 5,
                           "position", new Vector3(2344 + 960, -751 + 540),
                           "Time", 3
                           ));

            next++;
            
        }
        if (next == 2)
        { currT += Time.deltaTime;
           
            if (currT >= changeT)
            {    color.a -= 0.01f * changeSpd * Time.deltaTime;
                if (color.a <= 0.7) { color.a -= 0.01f * changeSpd*2 * Time.deltaTime; }
                if (color.a <= 0.3) { color.a = 0; }
                img.color = color;
            
            skColor.a += 0.01f * 30 * Time.deltaTime;
            skip.color = skColor;
            }
            
        }

    }
   public void SkipBtn()
    {
        SceneManager.LoadScene("PlayerSelection");
    }
}
