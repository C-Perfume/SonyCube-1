using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_OnTrigger : MonoBehaviour
{
    GameObject explo;
    GameObject explo1;
    AudioSource coinAudio;

    private void Start()
    {
        coinAudio = gameObject.GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.name.Contains("Ene") && !other.gameObject.name.Contains("Las")
            && !other.gameObject.name.Contains("Coi") && !other.gameObject.name.Contains("Dan"))
        {
            GetComponentInChildren<MeshRenderer>().material.SetColor("_Color", Color.clear);
            CSmanager.instance.AddCoin(Random.Range(3, 5));

            explo = transform.GetChild(0).gameObject;
            explo.SetActive(true);
            explo1 = transform.GetChild(1).gameObject;
            explo1.SetActive(true);
            coinAudio.Play();

            StartCoroutine(ActiveFalse());
        }
    }
    IEnumerator ActiveFalse()
    {
        yield return new WaitForSeconds(3);
        gameObject.SetActive(false);
        if (gameObject.name.Contains("Red")) 
        { GameObject.Find("1 RedCoinPoints").GetComponent<Enemy2Man>().enemyFool.Add(gameObject); }
        else { GameObject.Find("2 CoinPoints").GetComponent<Enemy2Man>().enemyFool.Add(gameObject); }
    }

}
