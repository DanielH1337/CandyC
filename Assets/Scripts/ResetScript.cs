using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResetScript : MonoBehaviour
{


    private ScoreScript Score;
    private MainMenuControlScript reset;
    // Start is called before the first frame update
    public void ResetValues()
    {
        Score = FindObjectOfType<ScoreScript>();
        Invoke("loadMainMenu", 1f);
        Score.resetvalues();
        
        
        
    }
     void loadMainMenu()
    {
        SceneManager.LoadScene(0);
    }

   
}
