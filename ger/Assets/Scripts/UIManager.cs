using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
	public Text scoreText;

	private int score;

	public Slider MusicSlider;
	public Slider SoundsSlider;

	void Start()
	{
		Time.timeScale = 1;
		score = PlayerPrefs.GetInt("savescore");
		scoreText.text = $"Your best score: {score}";
	}
	public void Reload()  
	{
		//SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		SceneManager.LoadScene(0);
		
	}
	//loads inputted level 
	public void LoadLevel(string level)
	{
		SceneManager.LoadSceneAsync(level);
	}
	public void Exit()
	{
		Debug.Log("Exit pressed");
		Application.Quit();
	}

	public void MusicVol()
    {
		if (MusicSlider.interactable == true)
			MusicSlider.interactable = false;
		else
			MusicSlider.interactable = true;
	}
	public void SoundsVol()
	{
		if (SoundsSlider.interactable == true)
			SoundsSlider.interactable = false;
		else
			SoundsSlider.interactable = true;
	}

}

