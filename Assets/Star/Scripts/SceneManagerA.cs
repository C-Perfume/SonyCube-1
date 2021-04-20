using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerA : MonoBehaviour
{
    public void OnClickRetry()
    {
        SceneManager.LoadScene("PlayerScene");
    }

    public void OnClickStart()
    {
        SceneManager.LoadScene("PlayerSelection");
    }

   
}
