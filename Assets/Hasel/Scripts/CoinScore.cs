using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScore : MonoBehaviour
{
    //자기 자신의 인스턴스를 담는것, 자기 자신을 변수 선언
    public static CoinScore instance;

    //베스트 점수
    int bestCoin;
    //베스트 점수 UI(TEXT)
    public Text BestCoinUI;

    //Start보다 Awake가 먼저 호출됨

    private void Awake()
    {
        instance = this; //this = 자기자신을 뜻함
    }


    private void Start()
    {
        SetBestCoin(PlayerPrefs.GetInt("BC"));

    }

    public void AddCoin(int addValue)
    {
        //1. 찾은 ScoreManager 컴포넌트(클래스) bestCoin 증가
        bestCoin++;
        //2. 스코어 UI갱신
        BestCoinUI.text = "Coin : " + bestCoin;
        SetBestCoin(bestCoin);
        //베스트 코인 저장
        PlayerPrefs.SetInt("BC", bestCoin);
    }

    void SetBestCoin(int BC)
    {
        bestCoin = BC; //베스트 코인을 현재 코인으로 갱신        
        BestCoinUI.text = "BestScore : " + bestCoin; //베스트 코인 UI 갱신
    }
}