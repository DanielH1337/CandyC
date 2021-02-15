
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelControlScript : MonoBehaviour
{

	public static LevelControlScript instance = null;
	GameObject levelSign, gameOverText, youWinText;
	int sceneIndex, levelPassed;
	private ScoreScript resetscore;
	private TimerScript stoptime;
	public Animator transition;
	public Animator virusanimation;
	public float transitionTime = 1f;
	GameObject virus1, virus2;
	public float time=0.00f;
	// Use this for initialization
	void Start()
	{

		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy(gameObject);

		stoptime = FindObjectOfType<TimerScript>();
		levelSign = GameObject.Find("LevelNumber");
		gameOverText = GameObject.Find("GameOverText");
		youWinText = GameObject.Find("YouWinText");
		gameOverText.gameObject.SetActive(false);
		youWinText.gameObject.SetActive(false);

		sceneIndex = SceneManager.GetActiveScene().buildIndex;
		levelPassed = PlayerPrefs.GetInt("LevelPassed");
		if (sceneIndex == 5)
        {
			virus1 = GameObject.Find("virusEnemy 1");
			virus2 = GameObject.Find("virusEnemy 2");
			//virus1.gameObject.SetActive(true);
			//virus2.gameObject.SetActive(false);
			
        }

	}
	void Update()
    {
		time = time + Time.deltaTime;
		Debug.Log(time);
        if (sceneIndex == 5)
        {
			virus2.transform.position = new Vector3(14.15f, 1.05f, -1652.5f);
            if (time > 10.00f)
            {
				virus1.transform.position = new Vector3(-11f, 1f, -1652.5f);
				virus2.transform.position = new Vector3(7.46f, 1.05f, -1652.5f);
            }
            if (time > 20.00f)
            {
				virus1.transform.position = new Vector3(-4.21f, -2.16f, -1652.5f);
				virus2.transform.position = new Vector3(14.15f, 1.05f, -1652.5f);
            }
            if (time > 30.00f)
            {
				virus1.transform.position = new Vector3(-11f, 1f, -1652.5f);
				virus2.transform.position = new Vector3(7.46f, 3.26f, -1652.5f);
            }
            if (time > 40.00f)
            {
				virus1.transform.position = new Vector3(-4.21f, 3.28f, -1652.5f);
				virus2.transform.position = new Vector3(14.15f, 1.05f, -1652.5f);
            }
			if(time > 50.00f)
            {
				virus1.transform.position = new Vector3(-11f, 1.05f, -1652.5f);
				virus2.transform.position = new Vector3(7.46f, -1.55f, -1652.5f);
            }
        }
		
		
    }

	public void youWin()
	{
		if (sceneIndex == 6)
			resetallvalues();


		else
		{
			if (levelPassed < sceneIndex)
				PlayerPrefs.SetInt("LevelPassed", sceneIndex);
			//levelSign.gameObject.SetActive(false);
			youWinText.gameObject.SetActive(true);
			stoptime.stopTime = false;
			loadNextLevel();
		}
	}

	public void youLose()
	{
		//levelSign.gameObject.SetActive(false);
		gameOverText.gameObject.SetActive(true);
		resetscore = FindObjectOfType<ScoreScript>();
		resetscore.EndScoreValue = false;
		loadMainMenu();
		resetscore.resetvalues();
	}

	void loadNextLevel()
	{
		StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
	}
	IEnumerator LoadLevel(int indexlevel)
    {
		transition.SetTrigger("Start");
		yield return new WaitForSeconds(transitionTime);
		SceneManager.LoadScene(indexlevel);
    }

	void loadMainMenu()
	{
		StartCoroutine(LoadLevel(0));
	}
	
	void resetallvalues()
    {
		
		stoptime.stopTime = false;
		youWinText.gameObject.SetActive(true);
		resetscore = FindObjectOfType<ScoreScript>();
		resetscore.resetvalues();
		PlayerPrefs.DeleteAll();
		loadMainMenu();
	}
}