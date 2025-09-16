using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ScoreManager : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateScoreText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void IncreaseScoreText(int amount)
    {
        score += amount;
        UpdateScoreText();
    }
    public void decreasescoreText(int amount)
    {
        score -= amount;
        UpdateScoreText();
    }
    public void UpdateScoreText()
    {
        scoreText.text = "score: "+score;
    }
}
