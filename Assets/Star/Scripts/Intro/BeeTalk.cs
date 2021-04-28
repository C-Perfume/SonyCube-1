using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BeeTalk : MonoBehaviour
{
    public GameObject beetalk;
    public GameObject playerTalk;
    public float beeShowup =22;
    public float playerShup = 5;

    void Start()
    {
        beetalk.SetActive(false);
        playerTalk.SetActive(false);
        StartCoroutine( Show());

          }

    IEnumerator Show()
    { yield return new WaitForSeconds(beeShowup); 
        beetalk.SetActive(true);
      yield return new WaitForSeconds(playerShup);
        beetalk.SetActive(false);
        playerTalk.SetActive(true);
    }

}