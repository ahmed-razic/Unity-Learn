using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Support4 : PlayerController
{
    private PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        Debug.Log("In Support4: " + age);
        Debug.Log("In Support4: " + city);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = playerController.transform.position + new Vector3(-6, -0.5f, 4);
    }
}
