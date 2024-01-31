using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    public float speed = 20.0f;
    private float backgroundLength;
    private Vector3 startPosition;
    private PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        backgroundLength = GetComponent<BoxCollider>().size.x;
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerController.gameOver == false)
        {
            transform.Translate(speed * Time.deltaTime * Vector3.left);
        }

        if (transform.position.x < startPosition.x - backgroundLength / 2)
        {
            transform.position = startPosition;
        }
    }
}
