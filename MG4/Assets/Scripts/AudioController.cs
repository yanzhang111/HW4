using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip flapClip;
    public AudioClip scoreClip;
    public AudioClip dieClip;

    void OnEnable()
    {
        PlayerController.OnPlayerFlap += PlayFlap;
        PlayerController.OnPlayerScored += PlayScore;
        PlayerController.OnPlayerDied += PlayDie;
    }

    void OnDisable()
    {
        PlayerController.OnPlayerFlap -= PlayFlap;
        PlayerController.OnPlayerScored -= PlayScore;
        PlayerController.OnPlayerDied -= PlayDie;
    }

    void PlayFlap()
    {
        audioSource.PlayOneShot(flapClip);
    }

    void PlayScore()
    {
        audioSource.PlayOneShot(scoreClip);
    }

    void PlayDie()
    {
        audioSource.PlayOneShot(dieClip);
    }
}