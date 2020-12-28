using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScript : MonoBehaviour
{


    private ScoreScript Score;
    // Start is called before the first frame update
    public void ResetValues()
    {
        Score = FindObjectOfType<ScoreScript>();
        Score.resetvalues();
    }

   
}
