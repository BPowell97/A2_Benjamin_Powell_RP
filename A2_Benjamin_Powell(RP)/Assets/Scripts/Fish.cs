using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{

    public int fishValue = 10;
    public float speed;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        rb.velocity = transform.forward * speed;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Pickup();
        }
    }

    private void Pickup()
    {
        //GameManager.Instance.NumFish++;
        GameManager.Instance.AddScore(fishValue); //Access to GameManager Script
        Destroy(gameObject);
    }
    
    
}
