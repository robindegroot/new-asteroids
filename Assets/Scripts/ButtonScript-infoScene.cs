using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class ButtonScript : MonoBehaviour
{
	public string InfoScene;

    public Button startButton; 

    void PlayGame()
    {
		SceneManager.LoadScene(InfoScene);
    }
}
