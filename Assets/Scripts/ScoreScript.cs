﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour

{
    public Text scoreText;
    public int score;



    // Update is called once per frame
    void Update()
    {
        scoreText.text = "" + score;


    }



    public void IncreaseScore(int amountToIncrease)
    {
        score += amountToIncrease;
    }

    void OnDisable()
    {
        PlayerPrefs.SetInt("Score", score);
    }
    private void OnEnable()
    {

        score = PlayerPrefs.GetInt("Score");
    }
    public void resetvalues()
    {
 
        PlayerPrefs.DeleteAll();
        score = 0;
        SceneManager.LoadScene(0);

    }



}
