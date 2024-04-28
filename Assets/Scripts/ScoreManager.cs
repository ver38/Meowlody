using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int pointsPerNote = 1;

    public int currentScore = 0;
    public int highScore;

    [SerializeField] Text scoreText;
    [SerializeField] Text highScoreText;
    [SerializeField] Text lastScoreText;
       




    // Start is called before the first frame update
    void Start()
    {

        currentScore = PlayerPrefs.GetInt("currentScore", 0);
        highScore = PlayerPrefs.GetInt("highScore", 0);

        //highScore = PlayerPrefs.GetInt("highScore".ToString(),Convert.ToInt32(currentScore));
        // Debug.Log(bestScore);

        scoreText.text = "Your score: " + currentScore.ToString();
        lastScoreText.text = currentScore.ToString();

        lastScoreText.text = "Your score: " + currentScore.ToString();
        highScoreText.text = "Max score: " + highScore.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        //currentScore = PlayerPrefs.GetInt("currentScore", 0);
        //highScore = PlayerPrefs.GetInt("highScore", 0);

        //highScore = PlayerPrefs.GetInt("highScore".ToString(),Convert.ToInt32(currentScore));
        // Debug.Log(bestScore);

        scoreText.text = "Your score: " + currentScore.ToString();
        //lastScoreText.text = currentScore.ToString();

       // lastScoreText.text = "Your score: " + currentScore.ToString();
        highScoreText.text = "Max score: " + highScore.ToString();
        

    }

    public void AddToScore()
    {
        currentScore = currentScore + pointsPerNote;
        // if (currentScore !< highScore)
        if (highScore < currentScore)
        {
            //PlayerPrefs.SetInt("highScore", currentScore);

            PlayerPrefs.SetInt("highScore".ToString(), currentScore);
            // Debug.Log("valore highscore " + highScore);
        }

        else
        {
            Debug.Log("still minor than high score");
        }
    }

    
}
