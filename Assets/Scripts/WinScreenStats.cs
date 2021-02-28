using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WinScreenStats : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI comboText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.SetText("Final score: " + InfoKeeperStatic.score + "!");
        comboText.SetText("Highest combo achieved: " + InfoKeeperStatic.highestCombo + "!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
