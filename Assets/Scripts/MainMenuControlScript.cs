﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuControlScript : MonoBehaviour
{

	public Button level02Button, level03Button,level04Button;
	int levelPassed;

	public Animator transition;
	public float transitionTime = 1f;
	private ScoreScript zerovalue;


	// Use this for initialization
	void Start()
	{
		levelPassed = PlayerPrefs.GetInt("LevelPassed");
		Debug.Log(levelPassed);
		level02Button.interactable = false;
		level02Button.gameObject.SetActive(false);
		level03Button.interactable = false;
		level03Button.gameObject.SetActive(false);
		level04Button.interactable = false;
		level04Button.gameObject.SetActive(false);

		//PlayerPrefs.DeleteAll();

		

		switch (levelPassed)
		{
			case 1:
				level02Button.interactable = true;
				level02Button.gameObject.SetActive(true);
				break;
			case 2:
				level02Button.interactable = true;
				level02Button.gameObject.SetActive(true);
				level03Button.interactable = true;
				level03Button.gameObject.SetActive(true);
				break;
			case 3:
				level02Button.interactable = true;
				level02Button.gameObject.SetActive(true);
				level03Button.interactable = true;
				level03Button.gameObject.SetActive(true);
				level04Button.interactable = true;
				level04Button.gameObject.SetActive(true);
				break;
			case 4:
				level02Button.interactable = true;
				level02Button.gameObject.SetActive(true);
				level03Button.interactable = true;
				level03Button.gameObject.SetActive(true);
				level04Button.interactable = true;
				level04Button.gameObject.SetActive(true);
				break;
			

		}
	}

	public void levelToLoad(int level)
	{

		StartCoroutine(LoadLevel(level));
	}
	IEnumerator LoadLevel(int indexlevel)
	{
		transition.SetTrigger("Start");
		yield return new WaitForSeconds(transitionTime);
		SceneManager.LoadScene(indexlevel);
	}

		public void resetPlayerPrefs()
	{
		//loadMain();
		level02Button.interactable = false;
		level02Button.gameObject.SetActive(false);
		level03Button.interactable = false;
		level03Button.gameObject.SetActive(false);
		level04Button.interactable = false;
		level04Button.gameObject.SetActive(false);
		PlayerPrefs.DeleteAll();
	}
	public void resetscore()
    {
		zerovalue = FindObjectOfType<ScoreScript>();
		zerovalue.zeroscore();
	}
	public void loadMain()
    {
		StartCoroutine(LoadLevel(0));
    }
	public void ResetPlayerprefsDelayed()
    {
		loadMain();
		Invoke("resetPlayerPrefs", 1f);
    }
}