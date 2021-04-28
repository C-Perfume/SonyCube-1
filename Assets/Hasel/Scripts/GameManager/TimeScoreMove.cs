using UnityEngine;

public class TimeScoreMove : MonoBehaviour
{
    RectTransform rt3;

    private void Start()
    {
        rt3 = GetComponent<RectTransform>();
    }
    void Update()
    {
        if (GameManager.instance.gState != GameManager.GameState.Play)
        {
            rt3.anchoredPosition = new Vector2(1200, -550);
        }
        else
        {
            rt3.anchoredPosition = new Vector2(3000, -550);
        }
    }
}