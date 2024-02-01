using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    private readonly float rotationSpeed = 100.0f;
    private float turnInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        turnInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, rotationSpeed * turnInput * Time.deltaTime);    
    }
}
