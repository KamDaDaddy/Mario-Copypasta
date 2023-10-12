using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text scoreText;
    public Text numberScore;
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

    public void AddScore()
    {
        score += 3;
        scoreText.text = "Score: " + score.ToString();
    }

    public void SubPoint()
    {
        score -= 1;
        scoreText.text = "Score: " + score.ToString();
    }

}
