﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour

{
    public Text scoreText;
    public  int score;
    public int ScoreToBeat;
    public bool EndScoreValue;
    int sceneIndex;
    public int value1;
    public int value2;

    private void Start()
    {

        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        EndScoreValue = true;
        
        
    }
    // Score is updating to text object in every match3 scene
    void Update()
    {
        
        scoreText.text = "" + score;

        if (score > ScoreToBeat)
        {
            //When youWin method is loaded and scene is 3 score is resetted.
            LevelControlScript.instance.youWin();
            if (sceneIndex == 3)
            {
                EndScoreValue = false;
                
            }
            
        }

    }


    //Scorevalue is increased from match3 script
    public void IncreaseScore(int amountToIncrease)
    {
        if (EndScoreValue==true)
            score += amountToIncrease;
        
            
    }
    //Score is subtracted when main menu is loaded
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

        PlayerPrefs.DeleteKey("Score");
        
        

    }
    public void zeroscore()
    {
        PlayerPrefs.DeleteKey("Score");
        score = 0;
    }
    public void level1scoreReset()
    {
        score = score - score;

    }
    public void level2scoreReset()
    {
        if (score - value1 >= 0)
        {
            score = score - value1;
            if (score > 600)
            {
                score = 300;
            }
        }
    }
    public void level3scoreReset()
    {
        if (score - value2 >= 0)
        {
            score = score - value2;
            if (score > 950)
            {
                score = 600;
            }
        }
    }
    
    
    

    


}
