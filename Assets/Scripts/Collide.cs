using UnityEngine;
using System.Collections;

public class Collide : MonoBehaviour {

	private ScoreController score;
	private ScoreController comboColor;

	private Level count;
	public bool hasHitSomething = false;


	void Start () 
	{
		//Initialzation from the ScoreController script
		score = GameObject.Find("Score").GetComponent<ScoreController>();
		comboColor = GameObject.Find ("Score").GetComponent<ScoreController>();
	}
	
	void Update () 
	{			

	}

	void OnCollisionEnter2D(Collision2D other)
	{			 
		//If-statement that only makes it possible for the brick to collide with objects under it. 
		if(other.contacts.Length > 0)
		{
			ContactPoint2D contact = other.contacts[0];
			if(Vector3.Dot(contact.normal, Vector3.up) > 0.5)
			{
				Debug.Log("hej");
				//Something needs to tell Instatiater that this object has collided!
				hasHitSomething = true;

				//this is legacy code
			}
		}

		if(hasHitSomething == true){

		//Detects collison between bricks. 
		//If the colors match it updates score and destroy the colliding bricks.

			if(this.gameObject.tag == "Blue" && other.gameObject.tag == "Blue" && comboColor.comboColor != 1)
			{
				Destroy(gameObject);
				score.score += 1;
				comboColor.comboColor = 1;
				count.count += 0.5f;
			}

			if(this.gameObject.tag == "Blue" && other.gameObject.tag == "Blue" && comboColor.comboColor == 1)
			{
				Destroy(gameObject);
				score.score += 2;
				count.count += 0.5f;
			}
		
			if(this.gameObject.tag == "Green" && other.gameObject.tag == "Green" && comboColor.comboColor != 2)
			{
				Destroy(gameObject);
				score.score += 1;
				comboColor.comboColor = 2;
				count.count += 0.5f;
			}
			
			if(this.gameObject.tag == "Green" && other.gameObject.tag == "Green" && comboColor.comboColor == 2)
			{
				Destroy(gameObject);
				score.score += 2;
				count.count += 0.5f;
			}

			if(this.gameObject.tag == "Orange" && other.gameObject.tag == "Orange" && comboColor.comboColor != 3)
			{
				Destroy(gameObject);
				score.score += 1;
				comboColor.comboColor = 3;
				count.count += 0.5f;
			}
			
			if(this.gameObject.tag == "Orange" && other.gameObject.tag == "Orange" && comboColor.comboColor == 3)
			{
				Destroy(gameObject);
				score.score += 2;
				count.count += 0.5f;
			}

			if(this.gameObject.tag == "Yellow" && other.gameObject.tag == "Yellow" && comboColor.comboColor != 4)
			{
				Destroy(gameObject);
				score.score += 1;
				comboColor.comboColor = 4;
				count.count += 0.5f;
			}
			
			if(this.gameObject.tag == "Yellow" && other.gameObject.tag == "Yellow" && comboColor.comboColor == 4)
			{
				Destroy(gameObject);
				score.score += 2;
				count.count += 0.5f;
			}

			if(this.gameObject.tag == "Purple" && other.gameObject.tag == "Purple" && comboColor.comboColor != 5)
			{
				Destroy(gameObject);
				score.score += 1;
				comboColor.comboColor = 5;
				count.count += 0.5f;
			}
			
			if(this.gameObject.tag == "Purple" && other.gameObject.tag == "Purple" && comboColor.comboColor == 5)
			{
				Destroy(gameObject);
				score.score += 2;
				count.count += 0.5f;
			}
		}
	}
}