using System.Collections;
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
        if (score>=5000)
        {
            LoadNextLevel();
            
        }
      
       
        
    }



    public void IncreaseScore(int amountToIncrease)
    {
        score += amountToIncrease;
    }
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(1);
        
    }
    void OnDisable()
    {
        PlayerPrefs.SetInt("Score", score);
    }
    private void OnEnable()
    {
        score = PlayerPrefs.GetInt("Score");
    }

}
