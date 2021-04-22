using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_OnTrigger : MonoBehaviour
{
    GameObject explo;
    GameObject explo1;
    public static bool die = false;
    public AudioSource coinAudio;
    private void Start()
    {
        coinAudio = gameObject.GetComponent<AudioSource>();
    }
    void Update()
    {
        if (die)
        { CoinDestroy.dieCoin = true; }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.name.Contains("Ene") || !other.gameObject.name.Contains("Las") || !other.gameObject.name.Contains("Coi"))
        {
            Destroy(gameObject, 0.2f);

            explo = transform.GetChild(0).gameObject;
            explo.SetActive(true);
            explo1 = transform.GetChild(1).gameObject;
            explo1.SetActive(true);
            coinAudio.Play();
            if (gameObject == GameObject.Find("CoinRed"))
            { die = true; }
        }

    }


}
