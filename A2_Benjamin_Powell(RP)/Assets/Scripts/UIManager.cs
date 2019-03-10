﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI healthText;

    private void Awake()
    {
        Instance = this;
    }

    public void UpdateScore()
    {
        scoreText.text = "Score: <color=white>" + GameManager.Instance.score.ToString();
    }

    public void UpdateHealth()
    {
        healthText.text = "Health: <color=white>" + GameManager.Instance.health.ToString();
    }

   
}
