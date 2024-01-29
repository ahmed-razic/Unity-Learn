using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float planeSpeed = 15.0f;
    public float propellerSpeed = 100.0f;
    public float rotationSpeed = 100.0f;
    public float verticalInput;
    private GameObject propeller;

    // Start is called before the first frame update
    void Start()
    {
        // get first child of this GameObject
        propeller = transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = -Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * planeSpeed * Time.deltaTime);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * verticalInput);

        // make propeller spin
        propeller.transform.Rotate(Vector3.forward, Time.deltaTime * propellerSpeed);
    }
}
