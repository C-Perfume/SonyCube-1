using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public Text TimeText;
    public Text CurrentScoreUI;
    public Text BestScoreUI;
    float Sec;
    int Min;
    int Hour;
    int bestScore;
    float currScore;
    int cMin;
    int cHour;

    private void Start()
    {
        Sec = 55;
        bestScore = PlayerPrefs.GetInt("BT");
        BestScoreUI.text = "최대 점수 : " + bestScore;
    }
    private void Update()
    {
        TimeFlow();
    }

    void TimeFlow()
    {
        Sec += Time.deltaTime;
        currScore += Time.deltaTime;
        CurrentScoreUI.text = "현재 점수 : " + Mathf.Round(currScore).ToString();
        TimeText.text = string.Format("{0:D2}:{1:D2}:{2:D2}", Hour, Min, (int)Sec);        

        if ((int)Sec > 59)
        {
            Sec = 0;
            Min++;
        }
        else if (Min > 59)
        {
            Min = 0;
            Hour++;
        }

        if (currScore > bestScore)
        {
            SetBestTime((int)(currScore)); //베스트 점수 저장
            PlayerPrefs.SetInt("BT", bestScore);
        }
    }
    void SetBestTime(int BS)
    {
        bestScore = BS; //베스트 점수를 현재 점수로 갱신        
        BestScoreUI.text = "최대 점수 : " + bestScore; //베스트 점수 UI 갱신
    }
}
