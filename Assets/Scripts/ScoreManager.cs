using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
   // public int noteCount;
    public Text scoreText;
    public Text highScoreText;
    public Text lastScoreText;

    public int score;
    //public int score = 0;
    public int highScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        score = PlayerPrefs.GetInt("score", 0);
        highScore = PlayerPrefs.GetInt("highScore", 0);

        scoreText.text = "Score: " + score.ToString();
        lastScoreText.text = score.ToString();

        lastScoreText.text = "Your score: " + score.ToString();
        highScoreText.text = "Max score: " + highScore.ToString();
    }

    public void AddPoint()
    {
        score += 10;
        scoreText.text = "Score: " + score.ToString();
        lastScoreText.text = "Score: " + score.ToString();

        if (highScore < score)
            PlayerPrefs.SetInt("highScore", score);

    }

   

    // Update is called once per frame
    void Update()


    {

    }
}
