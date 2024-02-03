using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;
    private readonly float spawnTime = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnTargets());
    }

    IEnumerator SpawnTargets()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnTime);
            int randomIndex = Random.Range(0, targets.Count);
            Instantiate(targets[randomIndex]);
            Debug.Log(randomIndex);
        }
    }
}
