using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_OnTrigger : MonoBehaviour
{
    GameObject eft;
    GameObject eft_1;
    AudioSource coinAudio;
    public int rand;
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

            eft = transform.GetChild(0).gameObject;
            eft.SetActive(true);
            eft_1 = transform.GetChild(1).gameObject;
            eft_1.SetActive(true);
            coinAudio.Play();

           if (gameObject.name.Contains("Red"))
            {
                GameObject e3 = GameObject.Find("E3 Spawner");
                if (e3 != null) { GameObject.Find("E3 Spawner").GetComponent<Enemy3Man>().AllDeactive(); }
                GameObject e2 = GameObject.Find("E2 Spawner");
                if (e2 != null) { GameObject.Find("E2 Spawner").GetComponent<Enemy2Man>().AllDeactive(); }
            }

            StartCoroutine(ActiveFalse());
        } 
        
           
    }
    IEnumerator ActiveFalse()
    {
        yield return new WaitForSeconds(3);
        gameObject.SetActive(false);
    }

}
