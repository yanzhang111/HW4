using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    public TMP_Text scoreText;
    public GameObject gameOverPanel;

    void OnEnable()
    {
        GameController.OnScoreChanged += UpdateScore;
        PlayerController.OnPlayerDied += ShowGameOver;
    }

    void OnDisable()
    {
        GameController.OnScoreChanged -= UpdateScore;
        PlayerController.OnPlayerDied -= ShowGameOver;
    }

    void Start()
    {
        scoreText.text = "0";
        gameOverPanel.SetActive(false);
    }

    private void UpdateScore(int newScore)
    {
        scoreText.text = newScore.ToString();
    }

    private void ShowGameOver()
    {
        gameOverPanel.SetActive(true);
    }
}
