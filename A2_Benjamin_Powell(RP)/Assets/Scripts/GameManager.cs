using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    public void AddScore(int newScore)
    {
        score += newScore;
        UIManager.Instance.UpdateScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
