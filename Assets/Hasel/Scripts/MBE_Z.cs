using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MBE_Z : MonoBehaviour
{
    GameObject target;
    public GameObject spawnDZ, spawnPoint;
    float jumpT = 4; //초기 이동시간
    public float movT = 1.5f; // 이동하는데 걸리는 시간
    public float delayT = 1f; // 이동 후 딜레이 시간
    float currT;
    float creatT = 0f;
    float dZoneCnt = 0;
    bool dz = false;
    

    private void OnEnable()
    {
        WakeUp();
    }


    void WakeUp()
    {
        iTween.MoveTo(gameObject, iTween.Hash("z", 5, "y", 1, "time", jumpT, "easeType", iTween.EaseType.easeOutCirc, "oncomplete", "DzFire", "oncompletetarget", this.gameObject));
    }
    void Moving()
    {
        if (gameObject.transform.position.z >= -5 && gameObject.transform.position.x <= 4)
        {
            iTween.MoveBy(gameObject, iTween.Hash("z", -1f, "time", movT, "delay", delayT, "oncomplete", "DzFire", "oncompletetarget", this.gameObject));
            //"looptype", iTween.LoopType.loop
        }
        else if (gameObject.transform.position.z <= 5)
        {
            float currT = 0;
            currT += Time.deltaTime;
            if (currT > movT + 1.5f)
            { gameObject.SetActive(false); 
                GameObject.Find("E1 Spawner").GetComponent<SpawnBlockEnemy>().ResetPosition(gameObject); currT = 0; }

                iTween.MoveTo(gameObject, iTween.Hash("z", -8, "y", -4, "time", movT + 2, "easeType", iTween.EaseType.easeOutCirc));
        }
    }
   
    void DzFire()
    {
        if (gameObject.transform.position.x >= -5 && gameObject.transform.position.z <= 5 && gameObject.transform.position.x < 5 && gameObject.transform.position.z > -5)
        {
            dz = true;
        }
        if (dz)
        {
            currT += Time.deltaTime;
            if (creatT < currT)
            {
                GameObject dZ = Instantiate(spawnDZ);
                dZ.transform.position = spawnPoint.transform.position;
                dZoneCnt++;
                currT = 0;
                //creatT += 0.03f;
            }
        }

        if (dZoneCnt > 6)
        {
            dz = false;
        }
        Moving();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 7)
        {
            Destroy(other.gameObject);
        }
        else if (other.gameObject.name.Contains("Player"))
        {
            Destroy(other.gameObject);
        }
    }
}
