using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {

	public Rigidbody projectile;

	private float speed = 0f;
	private float spawnRate = 2f;
	private float nextFire = 0.0F;


	// Use this for initialization
	void Start () {
		InvokeRepeating ("spawn", 0, spawnRate);
	}

	// Update is called once per frame
	void Update () {


	}

	 void spawn()
	{
		spawnRate = 2f;
		nextFire = Time.time + spawnRate;

		Rigidbody instantiatedProjectile = Instantiate(projectile,
			transform.position,
			transform.rotation)
			as Rigidbody;

		instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0,speed));

	}
}