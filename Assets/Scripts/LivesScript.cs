using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesScript : MonoBehaviour
{
    public Text Lifes;
    public int lifes=1;
    public static int LoseLife=1;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {

        lifes = lifes * LoseLife;
        Lifes.text = "Yritykset: " + lifes ;
       

    }
    void Disable()
    {
        PlayerPrefs.SetInt("LoseLife",LoseLife);
    }
    void OnEnable()
    {
        PlayerPrefs.GetInt("LoseLife", LoseLife);
    }
    public void loselifefunction()
    {
       LoseLife = 0;
    }
    
}
