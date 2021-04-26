using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManagerA : MonoBehaviour
{
    public void OnClickRetry()
    {
        SceneManager.LoadScene("PlayerScene");
        GameManager.instance.gState = GameManager.GameState.Ready;
        GameManager.instance.Ready();
    }

    public void OnClickStart()
    {
        SceneManager.LoadScene("PlayerSelection");
    }

    public void OnClickEnd()
    {
        Application.Quit();
    }

}
