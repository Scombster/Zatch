using UnityEngine;
using System.Collections;

public class Falling : MonoBehaviour {
	//This is part of harddrop
	//Target pointing to ButtomLayer
	//public Transform target;
	//Hard drop speed
	//float hardSpeed = 1.5f;



	float MoveCD = 0f;
	float Speed = 0.5f;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//Temp. controller scipt //Bear out
		if(Input.GetKeyDown("left")){
			transform.position += new Vector3(-1f,0,0);
		}
		if(Input.GetKeyDown("right")){
			transform.position += new Vector3(1f,0,0);
		}
		if(Input.GetKeyDown("up")){
			//rotate
			transform.Rotate (Vector3.forward * 90);
		}
		if(Input.GetKeyDown("down")){
			transform.position += new Vector3(0,-1f,0);
		}
		if(Input.GetKeyDown("space")){
			//hard drop, just an idea to use MoveTowards
			//transform.position = Vector3.MoveTowards(transform.position, target.position, hardSpeed*Time.deltaTime);
		}






		//Should be deltatime because of FPS?
		if (MoveCD < Time.time)
		{
			transform.position += new Vector3(0, -1f, 0);
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
				transform.position += new Vector3(0, 0, 0);
			}
		}





	}

	void Move()
	{
		MoveCD = Speed + Time.time;

	}

}
