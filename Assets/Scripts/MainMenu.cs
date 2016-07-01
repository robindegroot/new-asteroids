using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public string startLevel;

	public GameObject MainMenuScreen;
    public GameObject GameScene;

    public int InfoScene { get; private set; }

    public void startGame()
	{
		SceneManager.LoadScene (startLevel);		
	}

	public void quitGame()
	{
		Debug.Log ("Game Exited");
		Application.Quit ();

	}
}
