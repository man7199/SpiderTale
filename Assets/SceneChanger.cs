using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
	
    public static void ChangeScene()
	{
		Time.timeScale = 1;
		SceneManager.LoadScene(1);
	}
	public static void ChangeScene2()
	{
		Time.timeScale = 1;
		SceneManager.LoadScene(2);
	}
	public static void MainMenu()
	{
		Time.timeScale = 1;
		SceneManager.LoadScene(0);
	}
	public void Exit()
	{
		Application.Quit();
	}
}