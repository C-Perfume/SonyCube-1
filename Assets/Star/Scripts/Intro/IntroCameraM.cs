using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroCameraM : MonoBehaviour
{
    public GameObject bee;
    int i = 0;
    public enum beeState
    {
        Wait,
        Nomal,
        Found,
        Move,
        SceneMove
    }
    GameObject beeChild;
    beeState bS;
    private void Start()
    {
        bee = GameObject.Find("FantasyBee");
        bee.SetActive(false);
        beeChild = bee.gameObject.transform.GetChild(2).gameObject;
        beeChild.SetActive(false);
        bS = beeState.Move;

    }
    void Update()
    {
        if (i == 0)
        {
            iTween.MoveTo(gameObject, iTween.Hash(
                "delay", 13,
                "position", new Vector3(0, 2.5f, -5),
                "time", 5
                 )); i++;

        }
        else if (i == 1)
        {
            StartCoroutine(Move1());
            i++;
        }
        else if (i == 2)
        {
            // StopCoroutine(Wait());
            bS = beeState.Found;
            StartCoroutine(Found());
            beeChild.SetActive(false);
            i++;
        }

        else if (i == 3)
        {
            bS = beeState.Move;
            Move();
            i++;
        }
        else if (i == 4)
        {
            StartCoroutine(SceneMove());
        } 
    }

        IEnumerator Move1()
        {
            yield return new WaitForSeconds(18);
            bee.SetActive(true);
            iTween.MoveTo(bee.gameObject, iTween.Hash(
               "delay", 1,
               "position", new Vector3(-20, 2, -6),
               "time", 5,
               "easetype", iTween.EaseType.easeOutBack
                         ));
            
           yield return new WaitForSeconds(3);

            iTween.MoveTo(bee.gameObject, iTween.Hash(
             "delay", 1,
             "position", new Vector3(-4, 2.5f, -7f),
             "time", 3,
             "easetype", iTween.EaseType.easeOutBack

             ));
         iTween.RotateFrom(bee.gameObject, -transform.right, 3);

        bS = beeState.Wait;
        }

        void Move()
        {
           iTween.MoveTo(bee.gameObject, iTween.Hash(
            "delay", 3,
            "position", new Vector3(-1.3f, 2.3f, -4.6f),
            "time", 1//,
                     // "easetype", iTween.EaseType.easeOutBack
            ));
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
            yield return new WaitForSeconds(300);
            SceneManager.LoadScene("PlayerSelection");
        }
    
}
