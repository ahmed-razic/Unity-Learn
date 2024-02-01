using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    private float horInput;
    private float verInput;
    private readonly float bound = 20f;

    private Rigidbody playerRigidbody;
    private AudioSource playerAudioSource;

    public AudioClip bounce;
    public AudioClip explosion;
    public AudioClip fireworks;

    public ParticleSystem explosionParticle;
    public ParticleSystem fireworksParticle;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        playerAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePLayer();
    }

    void MovePLayer()
    {
        horInput = Input.GetAxis("Horizontal");
        verInput = Input.GetAxis("Vertical");

        playerRigidbody.AddForce(horInput * speed * Vector3.right);
        playerRigidbody.AddForce(verInput * speed * Vector3.forward);

        ConstrainPlayer();
    }

    void ConstrainPlayer()
    {
        if (transform.position.x < -bound)
        {
            playerRigidbody.AddForce(Vector3.right, ForceMode.Impulse);
            playerAudioSource.PlayOneShot(bounce);
        }
        if (transform.position.x > bound)
        {
            playerRigidbody.AddForce(Vector3.left, ForceMode.Impulse);
            playerAudioSource.PlayOneShot(bounce);
        }
        if (transform.position.z < -bound)
        {
            playerRigidbody.AddForce(Vector3.forward, ForceMode.Impulse);
            playerAudioSource.PlayOneShot(bounce);
        }
        if (transform.position.z > bound)
        {
            playerRigidbody.AddForce(Vector3.back, ForceMode.Impulse);
            playerAudioSource.PlayOneShot(bounce);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            explosionParticle.Play();
            playerAudioSource.PlayOneShot(explosion);
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("Powerup"))
        {
            fireworksParticle.Play();
            playerAudioSource.PlayOneShot(fireworks);
            Destroy(collision.gameObject);
        }
    }
}
