using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using SaveSystem;

public class GameManager : MonoBehaviour
{
    public GameObject GameOverUI, PauseUI, LoadingPanel, score, spawner;
    public Text finalScore;
    bool gameHasEnded = false;
    string score_value;
    //public SavedProgress progress, score1, score2, score3, score4, score5, score6, score7, score8, score9, score10, score11;

    public void GameOver()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            score.SetActive(false);
            spawner.SetActive(false);
            score_value = score.GetComponent<Text>().text;
            EasySave.Save("score9", int.Parse(score_value));
            finalScore.text = score_value;
            GameOverUI.SetActive(true);
            DumbSort();
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }

    public void MainMenu()
    {
        SceneManager.LoadSceneAsync("MainMenu");
        LoadingPanel.SetActive(true);
        //Time.timeScale = 1;
    }

    public void StartGame()
    {
        SceneManager.LoadSceneAsync("Main");
        LoadingPanel.SetActive(true);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        PauseUI.SetActive(true);
    }

    public void ResumeGame()
    {
        PauseUI.SetActive(false);
        Time.timeScale = 1;
    }

    void DumbSort()
    {
        int temp;

        if (EasySave.Load<int>("score9") > EasySave.Load<int>("score8"))
        {
            temp = EasySave.Load<int>("score8");
            EasySave.Save("score8", EasySave.Load<int>("score9"));
            EasySave.Save("score9", temp);
        }

        if (EasySave.Load<int>("score8") > EasySave.Load<int>("score7"))
        {
            temp = EasySave.Load<int>("score7");
            EasySave.Save("score7", EasySave.Load<int>("score8"));
            EasySave.Save("score8", temp);
        }

        if (EasySave.Load<int>("score7") > EasySave.Load<int>("score6"))
        {
            temp = EasySave.Load<int>("score6");
            EasySave.Save("score6", EasySave.Load<int>("score7"));
            EasySave.Save("score7", temp);
        }

        if (EasySave.Load<int>("score6") > EasySave.Load<int>("score5"))
        {
            temp = EasySave.Load<int>("score5");
            EasySave.Save("score5", EasySave.Load<int>("score6"));
            EasySave.Save("score6", temp);
        }

        if (EasySave.Load<int>("score5") > EasySave.Load<int>("score4"))
        {
            temp = EasySave.Load<int>("score4");
            EasySave.Save("score4", EasySave.Load<int>("score5"));
            EasySave.Save("score5", temp);
        }

        if (EasySave.Load<int>("score4") > EasySave.Load<int>("score3"))
        {
            temp = EasySave.Load<int>("score3");
            EasySave.Save("score3", EasySave.Load<int>("score4"));
            EasySave.Save("score4", temp);
        }

        if (EasySave.Load<int>("score3") > EasySave.Load<int>("score2"))
        {
            temp = EasySave.Load<int>("score2");
            EasySave.Save("score2", EasySave.Load<int>("score3"));
            EasySave.Save("score3", temp);
        }

        if (EasySave.Load<int>("score2") > EasySave.Load<int>("score1"))
        {
            temp = EasySave.Load<int>("score1");
            EasySave.Save("score1", EasySave.Load<int>("score2"));
            EasySave.Save("score2", temp);
        }
    }
}
