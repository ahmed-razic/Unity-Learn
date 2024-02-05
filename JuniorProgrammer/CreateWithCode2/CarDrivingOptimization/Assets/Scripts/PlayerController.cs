using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horsePower = 1000f;
    public float turnPower = 50f;
    private Rigidbody playerRb;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        playerRb.AddRelativeForce(horsePower * Input.GetAxis("Vertical") * Vector3.forward);
        transform.Rotate(Vector3.up, turnPower * Input.GetAxis("Horizontal") * Time.deltaTime);
    }
}
