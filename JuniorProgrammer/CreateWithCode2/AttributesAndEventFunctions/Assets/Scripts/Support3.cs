using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Support3 : MonoBehaviour
{
    private PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("In Start");
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    private void Awake()
    {
        Debug.Log("In Awake");
    }

    private void FixedUpdate()
    {
        Debug.Log("In FixedUpdate");
    }

    private void Update()
    {
        Debug.Log("In Update");
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Debug.Log("In LateUpdate");
        transform.position = playerController.currentPosition + new Vector3(0, -0.5f, 7);
    }
}
