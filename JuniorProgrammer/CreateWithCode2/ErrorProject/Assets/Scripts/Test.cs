using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    List<GameObject> objectList = new List<GameObject>();
    GameObject[] objectArray = new GameObject[3];
    Dictionary<string, GameObject> objectDict = new Dictionary<string, GameObject>();


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MyCoroutine());
        Input.GetButtonDown("Fire1");
    }

    private IEnumerator MyCoroutine()
    {
        yield return new WaitForSeconds(5);
        Debug.Log("Hello, World!");
        StartCoroutine(MyCoroutine());
    }
}
