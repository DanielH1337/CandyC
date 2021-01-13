using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuControlScript : MonoBehaviour
{

	public Button level02Button, level03Button;
	int levelPassed;
	
	
	private ScoreScript zerovalue;
	


	// Use this for initialization
	void Start()
	{

		levelPassed = PlayerPrefs.GetInt("LevelPassed");
		level02Button.interactable = false;
		level02Button.gameObject.SetActive(false);
		level03Button.interactable = false;
		level03Button.gameObject.SetActive(false);

		

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
		}
	}

	public void levelToLoad(int level)
	{

		SceneManager.LoadScene(level);
	}

	public void resetPlayerPrefs()
	{
		level02Button.interactable = false;
		level02Button.gameObject.SetActive(false);
		level03Button.interactable = false;
		level03Button.gameObject.SetActive(false);
		PlayerPrefs.DeleteAll();
	}
	public void resetscore()
    {
		zerovalue = FindObjectOfType<ScoreScript>();
		zerovalue.zeroscore();
	}
}