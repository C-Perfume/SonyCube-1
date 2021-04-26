using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int selectedPlayer;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
           // DontDestroyOnLoad(GameObject.Find("Canvas/ReadyIMG"));
            // DontDestroyOnLoad(GameObject.Find("Canvas/GoIMG"));
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
        pM = GameObject.Find("PlayersEmpty").GetComponent<PlayerM>();
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
        if (GameManager.instance.gState != GameManager.GameState.Play && GameManager.instance.gState != GameManager.GameState.Tutorial)
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
