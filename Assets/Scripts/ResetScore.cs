﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResetScore : MonoBehaviour
{
    
    public void Clean()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(0);
        
    }
}