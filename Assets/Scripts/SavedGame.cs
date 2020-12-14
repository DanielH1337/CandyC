using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavedGame : MonoBehaviour
{
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        score=PlayerPrefs.GetInt("Player Score");

        

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void oldscorevalue(int old)
    {
        score = score + old;
    }

}
