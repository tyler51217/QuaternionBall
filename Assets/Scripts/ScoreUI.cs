using System;
using TMPro;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    private static int scoreInt;
    public static Action OnScoreUpdated;
    public TMP_Text scoreText;

    private void Start()
    {
        ScoreUI.OnScoreUpdated += UpdateScore;
        ResetScore();
    }

    public static void AddScore()
    {
        scoreInt++;
        OnScoreUpdated();
    }

    private void UpdateScore()
    {
        scoreText.text = scoreInt.ToString();
    }

    public static void ResetScore()
    {
        scoreInt = 0;
        OnScoreUpdated();
    }

    private void OnDestroy()
    {
        ScoreUI.OnScoreUpdated -= UpdateScore;
    }


}
