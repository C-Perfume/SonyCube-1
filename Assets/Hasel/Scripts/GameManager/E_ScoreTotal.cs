using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class E_ScoreTotal : MonoBehaviour
{
    public Text Curr_Coin_Text;
    public Text Total_Coin_Text;
    public Text CurrentTime_Text;

    // �ٸ� ������ �̷��� Score�� �����Ͽ� �����
    void Start()
    {
        PlayerPrefs.GetString(Total_Coin_Text.text);
        //bestScore = PlayerPrefs.GetInt("BestScore");
        Curr_Coin_Text.text = CSmanager.instance.CurrCounUi.text;
        Total_Coin_Text.text = CSmanager.instance.BestCoinUI.text;
        CurrentTime_Text.text = TimeFlowManager.instance.currTime.text;
    }
}
