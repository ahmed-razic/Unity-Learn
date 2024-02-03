using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effects : MonoBehaviour
{
    public AudioSource effectsAudioSource;
    
    public AudioClip explosion;
    public AudioClip bounce;
    public AudioClip fireworks;

    public ParticleSystem explosionParticle;
    public ParticleSystem fireworksParticle;

    // Start is called before the first frame update
    void Start()
    {
        effectsAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayExplosion()
    {
        explosionParticle.Play();
        effectsAudioSource.PlayOneShot(explosion);
    }
    public void PlayFireworks()
    {
        fireworksParticle.Play();
        effectsAudioSource.PlayOneShot(fireworks);
    }

    public void PlayBounce()
    {
        effectsAudioSource.PlayOneShot(bounce);
    }

    public void PlayShot()
    {

    }
}
