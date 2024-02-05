using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float forwardSpeed = 10f;
    [SerializeField] private float turnSpeed = 100f;
    public string myName = "Ahmed";
    public Vector3 currentPosition;
    public static double myIncome = 10000d;
    public static double myIncomePrivate = 20000d;

    private protected const int age = 48;
    private protected readonly string city;

    // Start is called before the first frame update
    void Start()
    {

    }

    public PlayerController()
    {
        city = "Sarajevo";
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Vertical") * forwardSpeed * Time.deltaTime * Vector3.forward);
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * Input.GetAxis("Horizontal"));
        currentPosition = transform.position;
    }
}
