using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score; // stores score value

    public TextMeshProUGUI scoreText; // visual text element to be modified

    public void IncreaseScore(int amount)
    {
        score += amount; // adds specified amount to score
        UpdateScoreText(); // calls UpdateScoreText method
    }

    public void DecreaseScore(int amount)
    {
        score -= amount; // subtracts specified amount to score
        UpdateScoreText(); // calls UpdateScoreText method
    }

    public void UpdateScoreText()
    {
        scoreText.text = "Score: " + score; // sets score text display
    }
}
