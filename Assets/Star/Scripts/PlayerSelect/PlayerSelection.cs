using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelection : MonoBehaviour
{
    public RaycastHit hit;
    public GameObject player;

    void Update()
    {
        RayInfo();
    }

    public void RayInfo()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.gameObject.name.Contains("BG") != true)
            {
                player = hit.transform.gameObject;
                // player 선택 숫자값 변경
                GameMan.instance.selectedPlayer = int.Parse(player.name);
            }
        }
    }
}
