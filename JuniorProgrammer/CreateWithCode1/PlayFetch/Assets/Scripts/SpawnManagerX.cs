using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval = 2.0f;

    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating(nameof(SpawnRandomBall), startDelay, spawnInterval);
    }

    // Spawn random ball at random x position at top of play areastav

    void SpawnRandomBall()
    {
        // Generate random ball index and random spawn position
        int index = Random.Range(0, ballPrefabs.Length);
        Vector3 spawnPos = new(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[index], spawnPos, ballPrefabs[index].transform.rotation);

        // Generate random spawn interval value
        spawnInterval = Random.Range(1f, 5f);

        Debug.Log(spawnInterval);
    }
}
