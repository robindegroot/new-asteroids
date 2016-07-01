using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class ButtonScript2 : MonoBehaviour
{
	public string GameScene2;

	public Button startButton; 

	void PlayGame()
	{
		SceneManager.LoadScene(GameScene2);
	}
}
