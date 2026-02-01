using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController Instance;

    private int score = 0;

    public static event System.Action<int> OnScoreChanged;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void OnEnable()
    {
        PlayerController.OnPlayerScored += HandleScore;
        PlayerController.OnPlayerDied += HandlePlayerDeath;
        PlayerController.OnPlayerFlap += HandlePlayerFlap;
    }

    void OnDisable()
    {
        PlayerController.OnPlayerScored -= HandleScore;
        PlayerController.OnPlayerDied -= HandlePlayerDeath;
        PlayerController.OnPlayerFlap -= HandlePlayerFlap;
    }

    private void HandleScore()
    {
        score++;
        OnScoreChanged?.Invoke(score);
    }

    private void HandlePlayerDeath()
    { 
    }

    private void HandlePlayerFlap()
    {
    
    }
}
