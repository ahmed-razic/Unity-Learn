using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public List<GameObject> spawnList = new();
    public GameObject powerup;
    private readonly float random = 20.0f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(SpawnEnemies), 2, 2);
        InvokeRepeating(nameof(SpawnPowerups), 0, 15);
    }

    private void SpawnEnemies()
    {
        int randomIndex = Random.Range(0, spawnList.Count);
        Vector3 randomPosition = new(Random.Range(-random, random), 0.0f, 20.0f);
        Instantiate(spawnList[randomIndex], randomPosition, spawnList[randomIndex].transform.rotation);
    }

    private void SpawnPowerups()
    {
        Vector3 randomPosition = new(Random.Range(-random, random), 0.0f, Random.Range(-random, random));
        Instantiate(powerup, randomPosition, powerup.transform.rotation);
    }
}






