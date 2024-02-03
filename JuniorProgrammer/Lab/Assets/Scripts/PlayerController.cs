using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 30f;
    private float horInput;
    private float verInput;

    private Rigidbody playerRigidbody;
    private Effects effects;
    public GameObject missle;

    public bool hasPowerup;
    public GameObject powerupIndicator;
    public int powerUpDuration = 10;

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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(missle, transform.position + new Vector3(0, 0, 1.5f), missle.transform.rotation);
        }

        powerupIndicator.transform.position = transform.position + new Vector3(0, -0.6f, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Powerup"))
        {
            effects.transform.position = transform.position;
            effects.PlayFireworks();
            Destroy(collision.gameObject);

            hasPowerup = true;
            powerupIndicator.SetActive(true);
            StartCoroutine(PowerupCooldown());
        }

        IEnumerator PowerupCooldown()
        {
            yield return new WaitForSeconds(powerUpDuration);
            hasPowerup = false;
            powerupIndicator.SetActive(false);
        }

        if (collision.gameObject.CompareTag("Border"))
        {
            effects.PlayBounce();
        }
    }

    public void ResetPlayerPosition()
    {
        transform.position = new Vector3(0, 1, -15);
        transform.GetComponent<Rigidbody>().velocity = Vector3.zero;
        transform.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
    }
}
