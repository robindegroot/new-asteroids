using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TurnMovement : MonoBehaviour
{
	private bool Vooruit = false;
    private bool Rechts = false;
    private bool Links = false;
    private float turnRight = 0;
    private float turnLeft = 0;
    private float thrust = 0;
    private float maxThrust = 5;
	private bool Speed_ = false;
	private bool Invincible_ = false;
	private int scoreMultiplier = 10;
	public static float lives = 3f;
	
    void Start()
    {
        Debug.Log("hallo4");
        Texts.texts.PowerText.color = Color.grey;
        Texts.texts.SpeedText.color = Color.grey;
      //Audio.audio.Bite = GetComponent (typeof(AudioSource)) as AudioSource;
		UpdateUI ();
    }

	void FixedUpdate()
    {
		if (lives == 0f)
        {
			GameOver ();

		}
	}

	void GameOver()
    {
        Texts.texts.gameOverText.text = "Game over";
        Destroy (gameObject);
	}

    void Update()
    {
		

		if (Speed_)
        {
			maxThrust = 30;
		} else if (!Speed_)
        {
			maxThrust = 15;
		}
		//Debug.Log (thrust);
        transform.Translate(Vector3.up* Time.deltaTime * thrust);
        transform.Rotate(Vector3.forward * Time.deltaTime * turnLeft);
		transform.Rotate(Vector3.back * Time.deltaTime * turnRight);


        if (thrust < 0.1)
        {
            turnRight = 0;
            turnLeft = 0;
        }

        if (Input.GetKey("right") && thrust > 0.1)
        {
            Rechts = true;
            if (Rechts && turnRight < 200)
            {
                turnLeft = 0;
                turnRight += 5f;
                //Debug.Log(turnRight);
            }
            //transform.Rotate (Vector3.up * Time.deltaTime * turnRight);
        }
        if (Input.GetKeyUp("right"))
        {
            Rechts = false;

        }

        if (Input.GetKey("left") && thrust > 0.1)
        {
            Links = true;
            if (Links == true && turnLeft < 200)
            {
                turnRight = 0;
                turnLeft += 5f;
                //Debug.Log(turnLeft);
            }
            //transform.Rotate (Vector3.down * Time.deltaTime * turnLeft);
        }
        if (Input.GetKeyUp("left"))
        {
            Links = false;

        }

        if (Input.GetKey("space"))
        {
            Vooruit = true;
            if (Vooruit == true && thrust < maxThrust)
            {
                thrust += 0.2f;
            }
            //transform.Translate (Vector3.forward * Time.deltaTime * thrust);
        }

        if (Input.GetKeyUp("space"))
        {
            Vooruit = false;
        }

        if (thrust > 0)
        {
            thrust -= 0.05f;
        }
        if (Rechts == false && turnRight > 0)
        {
            turnRight -= 2.5f;
        }
        if (Links == false && turnLeft > 0)
        {
            turnLeft -= 2.5f;

        }
    }
    void OnTriggerEnter(Collider other)
    {
		if (other.tag == "fish")
        {
            Debug.Log("hallo");
            Audio.audio.Bite.Play ();
            Destroy(other.gameObject);
			Texts.texts.gameScore += scoreMultiplier;
			UpdateUI ();
            //Debug.Log (gameScore);
           

        }

		if (other.tag == "torpedo")
        {
            Debug.Log("hallo1");
            Audio.audio.explodeAudio.Play ();
			if (!Invincible_)
            {
				lives--;
			}
			Debug.Log (lives);
		}
		if (other.tag == "pickupSpeed")
        {
            Debug.Log("hall2o");
            Texts.texts.SpeedText.color = Color.green;
            Audio.audio.pickupAudio.Play ();
			Speed_ = true;
			InvokeRepeating ("powerup", 5, 0);
			Destroy (other.gameObject);
		}
		if (other.tag == "pickupPower")
        {
            Debug.Log("hallo3");
            Texts.texts.PowerText.color = Color.green;
            Audio.audio.pickupAudio.Play ();
			Invincible_ = true;
			InvokeRepeating ("powerup2", 10, 0);
			Destroy (other.gameObject);
		}
    }

	void powerup()
    {
		Speed_ = false;
        Texts.texts.SpeedText.color = Color.grey;
	}

	void powerup2()
    {
        Texts.texts.PowerText.color = Color.grey;
        Invincible_ = false;
	}

	void UpdateUI()
	{
		if (Texts.texts.gameScore > Texts.texts.highScore)
        {
            Texts.texts.highScore = Texts.texts.gameScore;
		}
        Texts.texts.scoreText.text = "Score: " + Texts.texts.gameScore;
        Texts.texts.highScoreText.text = "Highscore: " +  Texts.texts.highScore;
        Texts.texts.SpeedText.text = "Speed pickup";

        Texts.texts.PowerText.text = "Invincibility";

	}
}
