using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScore : MonoBehaviour
{
    //�ڱ� �ڽ��� �ν��Ͻ��� ��°�, �ڱ� �ڽ��� ���� ����
    public static CoinScore instance;

    
    public int bestCoin; //����Ʈ ����
    public int currCoin; //���� ����
    
    public Text BestCoinUI; //����Ʈ ���� UI(TEXT)
    public Text CurrCounUi; //���� ���� UI(TEXT)

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
        currCoin += addValue; //Coin ����
        SetBestCoin(Random.Range(3,5));
        PlayerPrefs.SetInt("BC", bestCoin); //���� ����
    }

    public void SetBestCoin(int BC)
    {
        bestCoin = BC; //���� ���η� ����        
        BestCoinUI.text = BC.ToString(); //���� UI ����
    }
}