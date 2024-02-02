using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float forwardSpeed = 70.0f;
    private Vector3 direction;
    private Vector3 hitDirection;
    private float forwardInput;
    private float powerupStrength = 15.0f;
    public bool hasPowerup;
    private Rigidbody playerRb;
    private GameObject focalPoint;
    public GameObject powerupIndicator;


    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point");
    }

    // Update is called once per frame
    void Update()
    {
        direction = focalPoint.transform.forward;
        forwardInput = Input.GetAxis("Vertical");
        playerRb.AddForce(forwardInput * forwardSpeed * direction);
        powerupIndicator.transform.position = transform.position + new Vector3(0, -0.5f, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Powerup"))
        {
            hasPowerup = true;
            powerupIndicator.SetActive(true);
            Destroy(other.gameObject);
            StartCoroutine(PowerupTimer());
        }
    }

    IEnumerator PowerupTimer()
    {
        yield return new WaitForSeconds(7);
        hasPowerup = false;
        powerupIndicator.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && hasPowerup)
        {
            Debug.Log("Collided with " + collision.gameObject.name + " with powerup set to " + hasPowerup);
            hitDirection = (collision.transform.position - transform.position).normalized;
            collision.rigidbody.AddForce(powerupStrength * hitDirection, ForceMode.Impulse);
        }
    }
}
