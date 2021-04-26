using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class introBeeM : MonoBehaviour
{
    GameObject beeChild;
    public Transform[] beepath;
    public Transform[] beepath2;

    public float talkT = 10;
   
    void Start()
    {
        gameObject.SetActive(false);
        beeChild = transform.GetChild(2).gameObject;
        beeChild.SetActive(false);
       
           }
    private void OnDrawGizmos()
    {
        iTween.DrawPath(beepath);
        iTween.DrawPath(beepath2);
    }
     void Update()
    {
        gameObject.SetActive(true); StartCoroutine(Wait());
            iTween.MoveTo(gameObject, iTween.Hash(
                  "delay", 1,
                  "path", beepath,
                  "looktime", .6,
                  "time", 5,
                  "easetype", iTween.EaseType.easeOutBack,
                  "oncomplete", "Move2"
                                        ));
            print("move active");
       
    }
    IEnumerator Wait()
    {
       yield return new WaitForSeconds(16);
    }
        

    void Move2()
    {
         iTween.MoveTo(gameObject, iTween.Hash(
              "delay", 3,
              "path", beepath2,
              "looktime", .6,
              "time", 3,
              "easetype", iTween.EaseType.easeOutBack,
              "oncomplete", "Found"
             ));
        print("move2 active");
    }


    IEnumerator Found()
    {
        yield return new WaitForSeconds(16);
        beeChild.SetActive(true);
        yield return new WaitForSeconds(1);
        beeChild.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        beeChild.SetActive(true);
        yield return new WaitForSeconds(1);
        beeChild.SetActive(false);

    }
    IEnumerator SceneMove()
    {
        yield return new WaitForSeconds(talkT);
        SceneManager.LoadScene("PlayerSelection");
    }

}
