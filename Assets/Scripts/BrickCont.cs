using UnityEngine;
using System.Collections;

public class BrickCont : MonoBehaviour {

	//int score;
	float MoveCD = 0f;
	float Speed = 0.5f;


	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {

		//Should be deltatime because of FPS?
		if (MoveCD < Time.time && this.enabled == true)
		{
			transform.position += new Vector3(0, -1, 0);
			Move ();
		}
		//
		/*if (Time.time >= 5f) 
		{
			Speed = 0.2f;	

		}*/


	}



	
	void OnCollisionEnter2D(Collision2D collision){
		//If-statement that only makes it possible for the brick to collide with objects under it. 
		if(collision.contacts.Length > 0)
		{
			ContactPoint2D contact = collision.contacts[0];
			if(Vector3.Dot(contact.normal, Vector3.up) > 0.5)
			{
				this.enabled = false;
				//transform.position += new Vector3(0, 0, 0);
			}
		}
		
		
		
		
		
	}
	
	void Move()
	{
		MoveCD = Speed + Time.time;
		
	}
}
