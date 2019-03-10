using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public int health = 100;
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        health = 100;
    }

    public void AddScore(int newScore)
    {
        score += newScore;
        UIManager.Instance.UpdateScore();
    }

    public void HealthScore(int newHealth)
    {
        health -= newHealth;
        UIManager.Instance.UpdateHealth();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
