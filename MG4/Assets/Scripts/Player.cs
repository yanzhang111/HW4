using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float flapForce = 5f;
    private Rigidbody2D rb;
    private bool isDead = false;

    public static event System.Action OnPlayerScored;
    public static event System.Action OnPlayerDied;
    public static event System.Action OnPlayerFlap;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (isDead) return;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * flapForce;
            OnPlayerFlap?.Invoke();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (isDead) return;

        if (collision.gameObject.CompareTag("Pipe"))
        {
            isDead = true;
            OnPlayerDied?.Invoke();
            Time.timeScale = 0f;
        }
    }
    public static void PlayerScored()
    {
        OnPlayerScored?.Invoke();
    }
}