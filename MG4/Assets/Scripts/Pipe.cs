using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Pipe : MonoBehaviour
{
    public float speed = 2f;
    public float destroyX = -15f;

    private bool hasScored = false;
    private Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        if (!hasScored && transform.position.x < player.position.x)
        {
            PlayerController.PlayerScored();
            hasScored = true;
        }

        if (transform.position.x < destroyX)
        {
            Destroy(gameObject);
        }
    }
}