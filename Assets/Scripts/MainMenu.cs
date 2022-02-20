using UnityEngine.UI;
using UnityEngine;
using SaveSystem;

public class MainMenu : MonoBehaviour
{
    public GameObject canvas_highscores, canvas_main, panel_scores;
    public void ShowScores()
    {
        canvas_main.SetActive(false);
        canvas_highscores.SetActive(true);
        int[] scoresArray = { EasySave.Load<int>("score1"), +
                            EasySave.Load<int>("score2"), +
                            EasySave.Load<int>("score3"), +
                            EasySave.Load<int>("score4"), +
                            EasySave.Load<int>("score5"), +
                            EasySave.Load<int>("score6"), +
                            EasySave.Load<int>("score7"), +
                            EasySave.Load<int>("score8")};

        Text[] textBoxes = panel_scores.GetComponentsInChildren<Text>();
        textBoxes[0].text = scoresArray[0].ToString();
        textBoxes[1].text = scoresArray[1].ToString();
        textBoxes[2].text = scoresArray[2].ToString();
        textBoxes[3].text = scoresArray[3].ToString();
        textBoxes[4].text = scoresArray[4].ToString();
        textBoxes[5].text = scoresArray[5].ToString();
        textBoxes[6].text = scoresArray[6].ToString();
        textBoxes[7].text = scoresArray[7].ToString();
    }

    public void HideScores()
    {
        canvas_highscores.SetActive(false);
        canvas_main.SetActive(true);
    }
}
