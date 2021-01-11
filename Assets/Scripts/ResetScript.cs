using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResetScript : MonoBehaviour
{


    private ScoreScript Score;
    // Start is called before the first frame update
    public void ResetValues()
    {
        Score = FindObjectOfType<ScoreScript>();
        Score.resetvalues();
        Invoke("loadMainMenu", 1f);
    }
    void loadMainMenu()
    {
        SceneManager.LoadScene(0);
    }

   
}
