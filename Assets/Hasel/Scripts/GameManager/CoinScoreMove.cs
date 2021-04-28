using UnityEngine;

public class CoinScoreMove : MonoBehaviour
{
    RectTransform rt1;

    private void Start()
    {
        rt1 = GetComponent<RectTransform>();
    }
    void Update()
    {
        if (GameManager.instance.gState != GameManager.GameState.Play)
        {
            rt1.anchoredPosition = new Vector2(1200, -300);
        }
        else
        {
            rt1.anchoredPosition = new Vector2(600, -100);
        }
    }
}
