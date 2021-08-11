using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ctrigger : MonoBehaviour
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
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.name.Contains("Ene") || !other.gameObject.name.Contains("Las") || !other.gameObject.name.Contains("Coi"))
        {
            CoinScore.instance.AddCoin(Random.Range(5, 10));
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
