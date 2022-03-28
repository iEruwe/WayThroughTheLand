using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
	public GUIStyle mystyle; //объ€вл€етс€ дл€ того чтобы измен€ть начертание GUI компонентов(шрифт, размер и.т.п.)
	string score;

	public Slider MusicSlider;
	public Slider SoundsSlider;

	void Start()
	{
			Time.timeScale = 1;
		StreamReader scoredata = new StreamReader(Application.persistentDataPath + "/score.gd"); //создание файловой переменной
		score = scoredata.ReadLine(); //чтение строки
		scoredata.Close(); //закрытие файловой переменной
	}
	void OnGUI()
	{
		GUI.Box(new Rect(Screen.width * 0.15f, Screen.height * 0.8f, Screen.width * 0.7f, Screen.height * 0.1f), "Max Distance:" + score, mystyle); //создаем небольшое окошко дл€ показа пройденного рассто€ни€
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

