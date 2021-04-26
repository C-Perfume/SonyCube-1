using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroCameraM : MonoBehaviour
{
    
    private void Start()
    {
       iTween.MoveTo(gameObject, iTween.Hash(
                 "delay", 13,
                 "position", new Vector3(0, 2.5f, -5),
                 "time", 5
                 ));
    }
   
  
}
