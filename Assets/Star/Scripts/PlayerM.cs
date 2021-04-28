using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerM : MonoBehaviour
{
    //선택가능한 Players 배열
    public GameObject[] playerModels;

    float currTime = 0;
    public float stopTime = 1;
    public float extraTime = 2;
    bool m = true;
    int mCunt = 0;

    public GameObject goBG;
    AudioSource stageBGM;
    void Start()
    {
        // 모델선택
        int selectedModel = GameMan.instance.selectedPlayer;
        playerModels[selectedModel].SetActive(true);

        goBG = GameObject.Find("Canvas/GameOverBG");
        stageBGM = GameObject.Find("StageBG").GetComponent<AudioSource>();
        if (goBG != null) { goBG.SetActive(false); }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.name.Contains("Coin") && !other.gameObject.name.Contains("RoC"))
        {
            if (goBG != null) { goBG.SetActive(true); stageBGM.Pause(); }
        }
    }
    void Update()
    {
        if (GameManager.instance.gState != GameManager.GameState.Play)
        { 
            return; 
        }

        if (mCunt == 0)
        {
            currTime += Time.deltaTime;
            if (currTime > stopTime + extraTime)
            { mCunt = 1; currTime = 0; }
        }
        if (m && mCunt == 1)
        {

            if (Input.GetKeyDown(KeyCode.S))
            {
                transform.position += Vector3.right;
                transform.eulerAngles = new Vector3(0, -0, 0);
                if (transform.position.x >= 4) transform.position = new Vector3(4, transform.position.y, transform.position.z);
            }

            if (Input.GetKeyDown(KeyCode.W))
            {
                transform.position += Vector3.left;
                transform.eulerAngles = new Vector3(0, -180, 0);
                if (transform.position.x <= -4) transform.position = new Vector3(-4, transform.position.y, transform.position.z);
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                transform.position += Vector3.back;
                transform.eulerAngles = new Vector3(0, 90, 0);
                if (transform.position.z <= -4) transform.position = new Vector3(transform.position.x, transform.position.y, -4);
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                transform.position += Vector3.forward;
                transform.eulerAngles = new Vector3(0, -90, 0);
                if (transform.position.z >= 4) transform.position = new Vector3(transform.position.x, transform.position.y, 4);
            }
            if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
            { mCunt++; }

            if (mCunt >= 2)
            {
                m = false;
                mCunt = 1;
            }
        }
        else
        {
            currTime += Time.deltaTime;
            if (mCunt == 1 && currTime >= stopTime)
            {
                m = true;
                currTime = 0;
            }
        }

    }
}
