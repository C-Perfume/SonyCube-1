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
        Pause,
        GameOver,
        Clear
    }

    public GameState gState;
    public GameObject gameOptionBG;
    public GameObject readyA;
    public GameObject go;
    PlayerM pM;
    AudioSource stageBGM;
    private void Start()
    {
        gState = GameState.Ready; 
        Ready();
        pM = GameObject.Find("PlayersEmpty").GetComponent<PlayerM>();
        stageBGM = GameObject.Find("StageBG").GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (pM.goBG != null && pM.goBG.activeSelf) { gState = GameState.GameOver; }
    }

    public void Ready()
    {
        StartCoroutine(ReadyToGo());
        go.SetActive(false);
        gameOptionBG.SetActive(false);
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
    public void PauseOption()
    {
        gameOptionBG.SetActive(true);
        Time.timeScale = 0;
        stageBGM.Pause();
        gState = GameState.Pause;
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
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void EndOption()
    {
        Application.Quit();
    }
}
