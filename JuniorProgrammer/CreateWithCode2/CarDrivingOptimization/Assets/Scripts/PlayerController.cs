using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horsePower = 1000f;
    public float turnPower = 50f;
    private Rigidbody playerRb;
    [SerializeField] private GameObject centerOfMass;

    [SerializeField] private TextMeshProUGUI speedometerText;
    [SerializeField] private TextMeshProUGUI rpmText;
    [SerializeField] private float speed;
    [SerializeField] private float rpm;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerRb.centerOfMass = centerOfMass.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        playerRb.AddRelativeForce(horsePower * Input.GetAxis("Vertical") * Vector3.forward);
        transform.Rotate(Vector3.up, turnPower * Input.GetAxis("Horizontal") * Time.deltaTime);

        speed = Mathf.Round(playerRb.velocity.magnitude * 3.6f); // 2.237f for mph
        speedometerText.SetText("Speed: " + speed + " kph");

        rpm = Mathf.Round((speed % 30) * 40);
        rpmText.SetText("RPM: " + rpm);
    }
}
