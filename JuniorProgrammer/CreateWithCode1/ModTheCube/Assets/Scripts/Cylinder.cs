using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Material material = GetComponent<MeshRenderer>().material;
        material.color = Color.blue;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(-5, 0, 0);
    }
}
