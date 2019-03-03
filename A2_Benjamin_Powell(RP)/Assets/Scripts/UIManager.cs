using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    public TextMeshProUGUI scoreText;

    private void Awake()
    {
        Instance = this;
    }

    public void UpdateScore()
    {
        scoreText.text = "Score: <color=white>" + GameManager.Instance.score.ToString();
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
