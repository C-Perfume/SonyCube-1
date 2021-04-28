using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class E_ScoreTotal : MonoBehaviour
{
    public Text Curr_Coin_Text;
    public Text Total_Coin_Text;
    public Text CurrentTime_Text;

    // 다른 씬에서 이뤄진 Score를 참조하여 갖고옴
    void Start()
    {
        PlayerPrefs.GetString(Total_Coin_Text.text);
        //bestScore = PlayerPrefs.GetInt("BestScore");
        Curr_Coin_Text.text = CSmanager.instance.CurrCounUi.text;
        Total_Coin_Text.text = CSmanager.instance.BestCoinUI.text;
        CurrentTime_Text.text = TimeFlowManager.instance.currTime.text;
    }
}
