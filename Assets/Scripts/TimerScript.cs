using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour

{
    Image timerBar;
    public float maxTime = 5f;
    float timelLeft;
    public GameObject timesUpText;
    private ResetScript button;
    public GameObject resetbutton;

    // Start is called before the first frame update
    void Start()
    {
        timesUpText.SetActive(false);
        timerBar = GetComponent<Image>();
        timelLeft = maxTime;
        resetbutton = GameObject.Find("ResetButton");
    }

    // Update is called once per frame
    void Update()
    {
        if (timelLeft > 0)
        {
            timelLeft -= Time.deltaTime;
            timerBar.fillAmount = timelLeft / maxTime;
        }
        else
        {
            
            timesUpText.SetActive(true);
            LevelControlScript.instance.youLose();
            
        }
    }
    
}
