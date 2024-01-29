using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float forwardSpeed = 20.0f;
    public float rotateSpeed = 50.0f;
    public float mouseInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(forwardSpeed * Time.deltaTime * Input.GetAxis("Vertical") * Vector3.forward);
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime * Input.GetAxis("Horizontal"));
        mouseInput = Input.GetAxis("Fire1");

        if (mouseInput == 1.0f)
        {
            Debug.Log("FIRE!");
        }
    }
}
