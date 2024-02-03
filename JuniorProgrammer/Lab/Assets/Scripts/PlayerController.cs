using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 30f;
    private float horInput;
    private float verInput;

    private Rigidbody playerRigidbody;
    private Effects effects;


    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        effects = GameObject.Find("Effects").GetComponent<Effects>();
    }

    // Update is called once per frame
    void Update()
    {
        horInput = Input.GetAxis("Horizontal");
        verInput = Input.GetAxis("Vertical");

        playerRigidbody.AddForce(horInput * speed * Vector3.right);
        playerRigidbody.AddForce(verInput * speed * Vector3.forward);
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Powerup"))
        {
            effects.transform.position = transform.position;
            effects.PlayFireworks();
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("Border"))
        {
            effects.PlayBounce();
        }
    }
}
