using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerA : MonoBehaviour
{
    public void OnClickStart()
    {
        SceneManager.LoadScene("PlayerScene");
    }

    //GameObject goBG;

    //private void Start()
    //{
    //    goBG = GameObject.Find("Canvas/GameOverBG");
    //    goBG.SetActive(false);
    //}
    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.name.Contains("Play"))
    //    { }
        
    //}
}
