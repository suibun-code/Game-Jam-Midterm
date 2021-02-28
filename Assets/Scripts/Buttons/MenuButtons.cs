using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public void OnClickPlay()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void OnClickCredits()
    {
        SceneManager.LoadScene("CreditsMenu");
    }

    public void OnClickExit()
    {
        Application.Quit();
    }

    public void OnClickMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void OnClickHowToPlay()
    {
        SceneManager.LoadScene("HowToPlay");
    }

    public void OnClickDifficulty()
    {
        SceneManager.LoadScene("DifficultyScene");
    }

    public void OnClickEasy()
    {
        InfoKeeperStatic.difficulty = 0;
        SceneManager.LoadScene("MainMenu");
    }

    public void OnClickMedium()
    {
        InfoKeeperStatic.difficulty = 1;
        SceneManager.LoadScene("MainMenu");
    }

    public void OnClickHard()
    {
        InfoKeeperStatic.difficulty = 2;
        SceneManager.LoadScene("MainMenu");
    }
}
