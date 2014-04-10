using UnityEngine;
using System.Collections;

public class Falling : MonoBehaviour {

	float MoveCD = 0f;

	float Speed = 0.5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		/*
		float horz = Input.GetAxis ("Horizontal");
		Vector3 velocity = rigidbody2D.velocity;
		velocity.x = horz;
		rigidbody2D.velocity = velocity;
		*/

		//Should be deltatime because of FPS
		if (MoveCD < Time.time)
		{
			transform.position += new Vector3 (0, -1f, 0);
			Move ();
		}

		/*if (Time.time >= 5f) 
		{
			Speed = 0.2f;	

		}*/


	}

	void OnCollisionEnter2D(Collision2D collision){
		this.enabled = false;
		transform.position += new Vector3 (0, 0, 0);
	}

	void Move()
	{
		MoveCD = Speed + Time.time;

	}

}
