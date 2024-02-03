using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private readonly float speed = 10.0f;
    private Effects effects;

    // Start is called before the first frame update
    void Start()
    {
        effects = GameObject.Find("Effects").GetComponent<Effects>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector3.forward);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Border"))
        {
            Destroy(gameObject, 2f);
        }

        if (other.gameObject.CompareTag("Player"))
        {
            effects.transform.position = transform.position;
            effects.PlayExplosion();
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}

