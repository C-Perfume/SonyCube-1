using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Click : MonoBehaviour
{
    public Text click;
    public float dir = -1;
    Color color;
    bool show;

    void Start()
    {
        color = click.color;
        color.a = 0;
        click.color = color;
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) { show = true; }
        if (show && click.name.Contains("Player"))
        {
            color.a -= 0.01f * dir;
            click.color = color;
            if (color.a >= 1) { color.a = 1; }
        }
        if (show && click.name.Contains("Click"))
        {
            color.a -= 0.01f * dir;
            click.color = color;
            if (color.a >= 1 || color.a <= 0) dir *= -1;
        }
    }
}
