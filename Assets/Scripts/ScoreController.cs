using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour
{
    private int score;
    private TMP_Text scoreText;
    void Awake()
    {
        scoreText = GetComponent<TMP_Text>();
        score = 0;
        UpdateScore();
    }
    public void IncreaseScore()
    {
        score += 10;
        UpdateScore();
    }
    void UpdateScore()
    {
        scoreText.text = "Score : " + score;
    }
}
