using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;

    public float spawnInterval = 2.5f;

    public float minOffsetY = -4f;
    public float maxOffsetY = 4f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnPipe), 1f, spawnInterval);
    }

    void SpawnPipe()
    {
        float offsetY = Random.Range(minOffsetY, maxOffsetY);

        Vector3 pos = new Vector3(transform.position.x, offsetY, 0);
        Instantiate(pipePrefab, pos, Quaternion.identity);
    }
}