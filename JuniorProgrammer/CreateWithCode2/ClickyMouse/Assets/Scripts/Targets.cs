using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targets : MonoBehaviour
{
    private Rigidbody targetRb;

    // Start is called before the first frame update
    void Start()
    {
        targetRb = GetComponent<Rigidbody>();
        transform.position = new Vector3(Random.Range(-4, 4), -4);
        targetRb.AddForce(Vector3.up * Random.Range(13, 17), ForceMode.Impulse);
        targetRb.AddTorque(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10), ForceMode.Impulse);

        Debug.Log(transform.position);
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Sensor"))
        {
            Destroy(gameObject);
        }
    }
}
