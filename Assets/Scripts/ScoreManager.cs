using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI numberScore;
    public int score = 0;
    
    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    public void AddScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score.ToString();
    }

    public void SubPoint()
    {
        score -= 1;
        scoreText.text = "Score: " + score.ToString();
    }

}
