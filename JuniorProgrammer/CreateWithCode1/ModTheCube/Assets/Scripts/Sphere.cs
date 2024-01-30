using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Material material = GetComponent<MeshRenderer>().material;
        material.color = Color.cyan;

        transform.Translate(0, 0, 10);
        transform.localScale = Vector3.one * 2.0f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, 1.0f);
    }
}
