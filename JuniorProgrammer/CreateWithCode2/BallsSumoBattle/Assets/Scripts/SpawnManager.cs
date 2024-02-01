using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    private readonly float spawnRange = 9.0f;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(enemyPrefab, RandomPosition(), enemyPrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private Vector3 RandomPosition()
    {
        return new Vector3(Random.Range(-spawnRange, spawnRange), 0, Random.Range(-spawnRange, spawnRange));
    }
}
