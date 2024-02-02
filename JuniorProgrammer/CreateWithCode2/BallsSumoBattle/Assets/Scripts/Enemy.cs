using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float speed = 3.0f;
    private Vector3 followVector;
    private GameObject player;
    private Rigidbody enemyRb;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        enemyRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        followVector = (player.transform.position - gameObject.transform.position).normalized;
        enemyRb.AddForce(followVector * speed);

        if(transform.position.y < - 5f)
        {
            Destroy(gameObject);
        }
    }
}
