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
}
