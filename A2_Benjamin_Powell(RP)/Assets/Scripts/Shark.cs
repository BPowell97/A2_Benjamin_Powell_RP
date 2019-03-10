using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shark : MonoBehaviour
{
    public float speed;

    private Rigidbody rb;

    public int playerDamage = 25;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        rb.velocity = transform.forward * speed;
    }

    private void OnTriggerEnter(Collider hitInfo)
    {
        Player player = hitInfo.GetComponent<Player>();
        if (player != null)
        {
            player.PlayerTakeDamage(playerDamage);
        }
     
    }
}
