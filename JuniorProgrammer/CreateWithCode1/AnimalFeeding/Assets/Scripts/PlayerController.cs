using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 30f;
    private readonly float xRange = 15f;
    public GameObject misslePrefab = null;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Move player left - right
        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime * Vector3.right);

        //Keep player in bounds -xRrange, xRange  
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        //Fire pizza missle
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(misslePrefab, transform.position, misslePrefab.transform.rotation);
        }
    }
}
