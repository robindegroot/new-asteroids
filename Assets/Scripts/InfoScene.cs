using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class InfoScene : MonoBehaviour {

	public string startLevel;

	public GameObject InfoScreen;
	public GameObject GameScene;

	public int GameScene2 { get; private set; }

	public void startGame()
	{
		SceneManager.LoadScene("gameScene");
	}

	public void quitGame()
	{
		Debug.Log ("Game Exited");
		Application.Quit ();

	}
}
