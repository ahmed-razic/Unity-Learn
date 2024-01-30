using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs = null;
    public List<GameObject> animalPrefabsList = null;
    private float xRange = 15f;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("List:");
        //foreach (GameObject obj in animalPrefabsList)
        //{
        //    Debug.Log(obj.name);
        //}

        //Debug.Log("Array:");
        //foreach (GameObject obj in animalPrefabs)
        //{
        //    Debug.Log(obj.name);
        //}

        InvokeRepeating(nameof(SpawnAnimals),2f, 2f);
    }

    private void SpawnAnimals()
    {
        int randomIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 randomPosition =  new (Random.Range(-xRange, xRange), transform.position.y, transform.position.z);
        Instantiate(animalPrefabs[randomIndex], randomPosition, animalPrefabs[randomIndex].transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {

    }


}
