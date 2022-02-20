using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text score;
    double timer = 0;
    void Update()
    {
        if (Time.timeScale > 0)
        {
            timer += Time.deltaTime * 8 + timer * 0.0001;
            score.text = timer.ToString("0");
        }
    }
}