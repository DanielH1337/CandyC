using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour

{
    public Text scoreText;
    public static int score;
    public int ScoreToBeat;
    public bool EndScoreValue;
    int sceneIndex;
    public int MinusPoints;


    private void Start()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        EndScoreValue = true;
    }
    // Update is called once per frame
    void Update()
    {
        
        scoreText.text = "" + score;

        if (score > ScoreToBeat)
        {
            
            LevelControlScript.instance.youWin();
            if (sceneIndex == 3)
            {
                EndScoreValue = false;
             
            }
            
        }

    }



    public void IncreaseScore(int amountToIncrease)
    {
        if (EndScoreValue==true)
            score += amountToIncrease;
        
            
    }

    void OnDisable()
    {
        if (score > 0)
        {
            score = score - MinusPoints;
        }

        
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
    

    


}
