using UnityEngine;
using System.Collections;

public class DeathMenu : MonoBehaviour {

	public string Menu;

	public bool isPaused;

	public GameObject DeathMenuCanvas;

	void Update () 
	{
		if (isPaused) 
		{	
			DeathMenuCanvas.SetActive (true);
			Time.timeScale = 0f;
		} 

		else 
		{
			DeathMenuCanvas.SetActive (false);
			Time.timeScale = 1f;
		}

		if (Input.GetKeyDown(KeyCode.Escape))
		{
			isPaused = !isPaused;
		}
	}


	public void resume()
	{
		isPaused = false;
	}

	public void GameMenu()
	{
		Application.LoadLevel (Menu);
	}
		
	public void quitGame()
	{
		Debug.Log ("Game Exited");
		Application.Quit ();
	}
}