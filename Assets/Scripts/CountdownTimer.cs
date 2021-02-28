using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{
    public TextMeshProUGUI timerText;

    float currentTime = 0f;
    private float startingTime = 140f;

    void Start()
    {
        currentTime = startingTime;
        timerText.SetText("" + currentTime);
    }

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        timerText.SetText("" + currentTime);

        if (currentTime <= 0f)
            SceneManager.LoadScene("WinScene");
    }
}
