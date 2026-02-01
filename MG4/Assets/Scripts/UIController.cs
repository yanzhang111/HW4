using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Text scoreText;

    void OnEnable()
    {
        GameController.OnScoreChanged += UpdateScore;
    }

    void OnDisable()
    {
        GameController.OnScoreChanged -= UpdateScore;
    }

    void Start()
    {
        scoreText.text = "0";
    }

    private void UpdateScore(int newScore)
    {
        scoreText.text = newScore.ToString();
    }
}