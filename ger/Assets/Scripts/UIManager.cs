using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class UIManager : MonoBehaviour
{
	public GUIStyle mystyle; //����������� ��� ���� ����� �������� ���������� GUI �����������(�����, ������ �.�.�.)
	string score;

	void Start()
	{
		StreamReader scoredata = new StreamReader(Application.persistentDataPath + "/score.gd"); //�������� �������� ����������
		score = scoredata.ReadLine(); //������ ������
		scoredata.Close(); //�������� �������� ����������
	}
	void OnGUI()
	{
		GUI.Box(new Rect(Screen.width * 0.15f, Screen.height * 0.8f, Screen.width * 0.7f, Screen.height * 0.1f), "Max Distance:" + score, mystyle); //������� ��������� ������ ��� ������ ����������� ����������
	}

	public void Reload()  
	{
		// SceneManager.LoadScene(SceneManager.GetActiveScene().name);
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
}

