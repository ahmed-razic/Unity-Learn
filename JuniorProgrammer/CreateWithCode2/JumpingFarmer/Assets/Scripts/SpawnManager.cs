using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private readonly float startDelay = 2.0f;
    private readonly float repeatRate = 3.0f;
    private Vector3 spawnPosition = new(30, 0, 0);

    private PlayerController playerController;
    public GameObject prefabObstacle;

    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating(nameof(SpawnObstacle), startDelay, repeatRate);
    }

    private void SpawnObstacle()
    {
        if (playerController.gameOver == false)
        {
            Instantiate(prefabObstacle, spawnPosition, prefabObstacle.transform.rotation);
        }
    }
}
