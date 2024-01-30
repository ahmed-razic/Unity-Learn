using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Camera mainCamera;
    public Camera hoodCamera;
    public float forwardSpeed = 20.0f;
    public float rotateSpeed = 50.0f;
    public KeyCode switchkey;
    public string inputID;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(forwardSpeed * Time.deltaTime * Input.GetAxis("Vertical" + inputID) * Vector3.forward);
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime * Input.GetAxis("Horizontal" + inputID));

        if (Input.GetKeyDown(switchkey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }
    }
}