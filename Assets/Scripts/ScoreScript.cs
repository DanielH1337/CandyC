using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour

{


    public Text scoreText;
    public int score;
    

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        scoreText.text = "" + score;
        if (score >= 1000)
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
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
