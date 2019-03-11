using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public int health = 100;
    public int score = 0;

    public Collider m_Collider;

    

    public int targetscore = 100;

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

    void FixedUpdate()
    {
        if (score >= targetscore && Input.GetKeyDown(KeyCode.Space))
        {
            m_Collider.enabled = !m_Collider.enabled; //Disables Collider
            
            targetscore += 100;

            StartCoroutine(EnableCollider());
        }
    }

    private IEnumerator EnableCollider()
    {
        yield return new WaitForSeconds(10); //Collider turns back on after 10 Seconds
        m_Collider.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
