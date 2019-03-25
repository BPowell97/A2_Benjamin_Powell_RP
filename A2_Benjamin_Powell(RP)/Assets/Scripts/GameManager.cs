using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GameManager : Singleton<GameManager>
{
    public int health = 100;
    public int score = 0;

    public Collider m_Collider;

    //Material playerMat;
    public float tweenTime = 0.5f;

    public int targetscore = 100;

    public Renderer playerMat;

    public GameObject image;

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
        /*if (score += 100)
        {
            image.SetActive(true);
        }*/

        if (score >= targetscore && Input.GetKeyDown(KeyCode.Space))
        {
            m_Collider.enabled = !m_Collider.enabled; //Disables Collider
            
            targetscore += 100;

            StartCoroutine(EnableCollider());

            playerMat.material.DOFade(0.5f, tweenTime);
        }
    }

    private IEnumerator EnableCollider()
    {
        yield return new WaitForSeconds(10); //Collider turns back on after 10 Seconds
        m_Collider.enabled = true;
        playerMat.material.DOFade(1f, tweenTime);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
