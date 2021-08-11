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
    public float bgmStop = 25;
    public float VolumeDown = 3;
    bool a = false;
    AudioSource bgAudio;

    float currT = 0;

    void Start()
    {
         a = false;
        beetalk.SetActive(false);
        playerTalk.SetActive(false);
        bgAudio = gameObject.GetComponent<AudioSource>();
        StartCoroutine( Show());
        StartCoroutine(StartBGM());
        StartCoroutine(StopBGM());
    }

    IEnumerator Show()
    { yield return new WaitForSeconds(beeShowup); 
        beetalk.SetActive(true);
      yield return new WaitForSeconds(playerShup);
        beetalk.SetActive(false);
        playerTalk.SetActive(true);
    }
    IEnumerator StartBGM()
    { yield return new WaitForSeconds(5);
    bgAudio.Play();}
    IEnumerator StopBGM()
    {
        yield return new WaitForSeconds(bgmStop);
        a = true;
    }

    private void Update()
    {

        if (a)
        {
            currT += Time.deltaTime;
            if (currT >= VolumeDown)
            {
                bgAudio.volume -= 0.1f * 3;
                currT = 0;
                if (bgAudio.volume <= 0.1) { bgAudio.volume = 0; a = false; }
            }
        }
    }
}
