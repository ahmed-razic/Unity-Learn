using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float forwardSpeed = 50.0f;
    private Vector3 direction;
    private float forwardInput;
    private Rigidbody playerRb;
    private GameObject focalPoint;


    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point");
    }

    // Update is called once per frame
    void Update()
    {
        direction = focalPoint.transform.forward;
        forwardInput = Input.GetAxis("Vertical");
        playerRb.AddForce(forwardInput * forwardSpeed * direction);
    }
}
