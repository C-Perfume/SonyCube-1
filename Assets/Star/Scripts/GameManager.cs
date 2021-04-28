using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
   

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            
        }
    }
    public enum GameState
    {
        Tutorial,
        Ready,
        ReadyToGo,
        Play,
        GameOver,
        Clear
    }

    public GameState gState;
    public GameObject gameOptionBG;
    public GameObject readyA;
    public GameObject go;
    PlayerM pM;
    AudioSource stageBGM;
    //AudioSource tutoBGM;
   // public AudioClip tutorialBGM;
    private void Start()
    {
        gState = GameState.Ready;//Tutorial; 
        pM = GameObject.Find("PlayersEmpty").GetComponent<PlayerM>();
        stageBGM = GameObject.Find("StageBG").GetComponent<AudioSource>();
        //tutoBGM = gameObject.GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (pM.goBG != null && pM.goBG.activeSelf) { gState = GameState.GameOver; }

        switch(gState)
        {
            case GameState.Tutorial:
                Tutorial();
                break;
            case GameState.Ready:
                Ready();
                break;
            case GameState.ReadyToGo:
                StartCoroutine(ReadyToGo());
                 break;
            case GameState.Play:
                Play();
                break;
           
            case GameState.GameOver:
                break;
            case GameState.Clear:
                break;
        }
    }

    void Tutorial()
    {// tutoBGM.Play(); gState = GameState.Ready;
     }

    public void Ready()
    {
        go.SetActive(false);
        gameOptionBG.SetActive(false);
        gState = GameState.ReadyToGo;
    }
    IEnumerator ReadyToGo()
    {
        yield return new WaitForSeconds(2);
        readyA.SetActive(false);
        go.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        go.SetActive(false);
        gState = GameState.Play;
    }
    void Play()
    { stageBGM.Play();
     StopAllCoroutines();
     }
    
    
    public void PauseOption()
    {
        gameOptionBG.SetActive(true);
        Time.timeScale = 0;
        stageBGM.Pause();
        //gState = GameState.Pause;
        //�� �Ҹ��� �ȸ��ߴ� ����? ���� ���� ���߰� �ٽ� rezoom�ؾ� �ȴٰ� ��

    }
    public void PlayOption()
    {
        gameOptionBG.SetActive(false);
        Time.timeScale = 1;
        stageBGM.UnPause();
        gState = GameState.Play;
    }
    public void RetryOption()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void EndOption()
    {
        Application.Quit();
    }
}
