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
        //Tutorial,
        Ready,
        //ReadyToGo,
        Play
        //GameOver,
        //Clear
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
        gState = GameState.Ready; Ready(); 
        pM = GameObject.Find("PlayersEmpty").GetComponent<PlayerM>();
        stageBGM = GameObject.Find("StageBG").GetComponent<AudioSource>();
        //tutoBGM = gameObject.GetComponent<AudioSource>();
    }

    private void Update()
    {
               //switch(gState)
        //{
        //    case GameState.Tutorial:
        //        Tutorial();
        //        break;
        //    case GameState.Ready:
                
        //        break;
        //    case GameState.ReadyToGo:
                
        //         break;
        //    case GameState.Play:
        //        Play();
        //        break;
           
        //    case GameState.GameOver:
        //        break;
        //    case GameState.Clear:
        //        break;
        //}
    }

    //void Tutorial()
    //{// tutoBGM.Play(); gState = GameState.Ready;
    // }

    public void Ready()
    {
        go.SetActive(false);
        gameOptionBG.SetActive(false);
        StartCoroutine(ReadyToGo());
    }
    IEnumerator ReadyToGo()
    {
        yield return new WaitForSeconds(2);
        readyA.SetActive(false);
        go.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        go.SetActive(false);
        gState = GameState.Play;
        stageBGM.Play();

    }
    //void Play()
    //{

    //}
        
    public void PauseOption()
    {
        gameOptionBG.SetActive(true);
        Time.timeScale = 0;
        stageBGM.Pause();
        //gState = GameState.Pause;
        //왜 소리는 안멈추는 거지? 원래 따로 멈추고 다시 rezoom해야 된다고 함

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
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void EndOption()
    {
        Application.Quit();
    }
}
