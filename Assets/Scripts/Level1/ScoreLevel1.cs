using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreLevel1 : MonoBehaviour
{
    public int noteValueLvl = 1;
    public int currentScoreValueLvl = 0;

    [SerializeField] Text scoreText;




    // Start is called before the first frame update
    void Start()
    {

        currentScoreValueLvl = PlayerPrefs.GetInt("currentScoreLvl", 0);
        scoreText.text = "Score: " + currentScoreValueLvl.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + currentScoreValueLvl.ToString();
    }

    public void AddToScore()
    {
        currentScoreValueLvl = currentScoreValueLvl + noteValueLvl;
        Debug.Log("nuovo score salvato" + currentScoreValueLvl);
    }

}
