using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{

    public int fishValue = 10;

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
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
