using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health = 100;
    //public GameObject losePanel;
    private Rigidbody myRigidbody;

    public void PlayerTakeDamage(int playerDamage)
    {
        health -= playerDamage;
        GameManager.Instance.HealthScore(playerDamage);
        if (health <= 0)
        {
            Die();
        }

    }

    void Die()
    {
        //myRigidbody.bodyType = RigidbodyType2D.Static;
        //losePanel.SetActive(true);
        Destroy(gameObject);
    }



}
