using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ctrigger : MonoBehaviour
{
    GameObject explo;
    GameObject explo1;
    public static bool die = false;
    AudioSource coinAudio;
    //MeshRenderer rocMr;

    private void Start()
    {
        coinAudio = gameObject.GetComponent<AudioSource>();
    }
    void Update()
    {
        if (die) CoinDestroy.dieCoin = true;        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.name.Contains("Ene") || !other.gameObject.name.Contains("Las") || !other.gameObject.name.Contains("Coi"))
        {
            GetComponentInChildren<MeshRenderer>().material.SetColor("_Color", Color.clear);
            Destroy(gameObject, 3);

            CoinScore.instance.AddCoin(Random.Range(3, 5));

            explo = transform.GetChild(0).gameObject;
            explo.SetActive(true);
            explo1 = transform.GetChild(1).gameObject;
            explo1.SetActive(true);
            coinAudio.Play();

            if (gameObject == GameObject.Find("CoinRed")) die = true;
        }
    }
}
