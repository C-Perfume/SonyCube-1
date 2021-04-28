using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScore : MonoBehaviour
{
    //자기 자신의 인스턴스를 담는것, 자기 자신을 변수 선언
    public static CoinScore instance;

    
    public int bestCoin; //베스트 점수
    public int currCoin; //현재 점수
    
    public Text BestCoinUI; //베스트 점수 UI(TEXT)
    public Text CurrCounUi; //현재 점수 UI(TEXT)

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
        currCoin += addValue; //Coin 증가
        SetBestCoin(Random.Range(3,5));
        PlayerPrefs.SetInt("BC", bestCoin); //코인 저장
    }

    public void SetBestCoin(int BC)
    {
        bestCoin = BC; //현재 코인량 갱신        
        BestCoinUI.text = BC.ToString(); //코인 UI 갱신
    }
}