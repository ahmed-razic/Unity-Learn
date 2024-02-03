using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public List<GameObject> spawnList = new List<GameObject>();
    private readonly float randomX = 20.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(SpawnEnemies), 2, 2);
    }

    private void SpawnEnemies()
    {
        int randomIndex = Random.Range(0, spawnList.Count);
        Vector3 randomPosition = new (Random.Range(-randomX, randomX), 0.0f, 20.0f);
        Instantiate(spawnList[randomIndex], randomPosition, spawnList[randomIndex].transform.rotation);
    }
}
