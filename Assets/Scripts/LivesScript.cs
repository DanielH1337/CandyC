using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesScript : MonoBehaviour
{
    private MainMenuControlScript lives;
    public Text Lives;
    int livecontainer;
    // Start is called before the first frame update
    void Start()
    {
        lives = FindObjectOfType<MainMenuControlScript>();
        livecontainer = lives.lives;
    }

    // Update is called once per frame
    void Update()
    {
        

        Lives.text = "Yritykset: " + livecontainer;
    }
    public void lifereset()
    {
        livecontainer = livecontainer + 1;
    }
}
