using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerA : MonoBehaviour
{
    public static GameManagerA instance;
   
    private void Awake()
    {
        if(instance == null)
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
    public GameObject gameOption;
    public GameObject readyA;
    public GameObject go;
    PlayerM pM;
    private void Start()
    {
        gState = GameState.Ready; Ready();
                  }

    private void Update()
    {
        if (pM.goBG!=null && pM.goBG.activeSelf) { gState = GameState.GameOver; }
    }

    public void Ready() 
    {
        StartCoroutine(ReadyToGo());
        go.SetActive(false);
        gameOption.SetActive(false);
    }
    IEnumerator ReadyToGo()
    { yield return new WaitForSeconds(2);
       readyA.SetActive(false); 
        go.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        go.SetActive(false);
        gState = GameState.Play;
    }
    public void PauseOption() 
    {
        if (GameManagerA.instance.gState != GameManagerA.GameState.Play && GameManagerA.instance.gState != GameManagerA.GameState.Tutorial)
        { return; }

        gameOption.SetActive(true);
        Time.timeScale = 0;
        gState = GameState.Pause;
        //왜 소리는 안멈추는 거지?

    }
    public void PlayOption ()
    {
        gameOption.SetActive(false);
        Time.timeScale = 1;
        gState = GameState.Play;
    }
    public void RetryOption()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //gState = GameState.Ready; Ready();
    }
        public void EndOption()
    {
        Application.Quit();
    }
}
