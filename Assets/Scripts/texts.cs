using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Texts : MonoBehaviour {
    public int gameScore;
    public int highScore;
    public Text scoreText;
    public Text highScoreText;
    public Text SpeedText;
    public Text PowerText;
    public Text gameOverText;
    public static Texts texts;
    void Start ()
    {
        texts = this;
	}
}
