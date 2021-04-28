using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScore : MonoBehaviour
{
    //�ڱ� �ڽ��� �ν��Ͻ��� ��°�, �ڱ� �ڽ��� ���� ����
    public static CoinScore instance;

    //����Ʈ ����
    int bestCoin;
    //����Ʈ ���� UI(TEXT)
    public Text BestCoinUI;
    public Text CurrCoinUI;

    //Start���� Awake�� ���� ȣ���

    private void Awake()
    {
        instance = this; //this = �ڱ��ڽ��� ����
    }


    private void Start()
    {
        SetBestCoin(PlayerPrefs.GetInt("BC"));
    }

    public void AddCoin(int addValue)
    {
        bestCoin+=addValue; //Coin ����
        SetBestCoin(bestCoin);
        PlayerPrefs.SetInt("BC", bestCoin); //���� ����
    }

    void SetBestCoin(int BC)
    {
        bestCoin = BC; //���� ���η� ����        
        BestCoinUI.text = BC.ToString(); //���� UI ����
    }
}