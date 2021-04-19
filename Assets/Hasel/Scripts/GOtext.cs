using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GOtext : MonoBehaviour
{
    public Text textTitle;
    public Text flickTitle;

    float alpha = 0;
    float dir1 = 1;

    // Start is called before the first frame update
    void Start()
    {
        //transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(gameover.player_die)
        alpha += 0.01f * dir1;
        textTitle.color = new Color(0.1f*dir1, 0.1f*dir1, 0.1f*dir1, alpha);
        //if (alpha >= 1 || alpha <= 0)
        //{
        //    dir1 *= -1;
        //}
    }
    public void OnClickStart()
    {
        SceneManager.LoadScene("Score");
    }
}
