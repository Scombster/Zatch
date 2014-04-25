using UnityEngine;
using System.Collections;

public class Collide : MonoBehaviour {
	public bool hasHitSomething = false;

	public ScoreController comboColor;

	private Level count;
	private ScoreController score;

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
		//Detects collison between bricks. 
		//If the colors match it updates score and destroy the colliding bricks.
		if(this.gameObject.tag == "Blue" && other.gameObject.tag == "Blue")
		{
			Destroy(gameObject);
			comboColor.comboColor = 1;
			
			if(comboColor.comboColor == 1)
			{
				score.score += 2;
				count.count += 0.5f;
			}
			else
			{
				score.score += 1;
				count.count +=0.5f;
			}
		}
		
		if(this.gameObject.tag == "Green" && other.gameObject.tag == "Green")
		{
			Destroy(gameObject);
			comboColor.comboColor = 2;
			
			if(comboColor.comboColor == 2)
			{
				score.score += 2;
				count.count +=0.5f;
			}
			else
			{
				score.score += 1;
				count.count +=0.5f;
			}

		}
		
		if(this.gameObject.tag == "Orange" && other.gameObject.tag == "Orange")
		{
			Destroy(gameObject);
			comboColor.comboColor = 3;
			
			if(comboColor.comboColor == 3)
			{
				score.score += 2;
				count.count +=0.5f;
			}
			else
			{
				score.score += 1;
				count.count +=0.5f;
			}
		}
		
		if(this.gameObject.tag == "Yellow" && other.gameObject.tag == "Yellow")
		{
			Destroy(gameObject);
			comboColor.comboColor = 4;
			
			if(comboColor.comboColor == 4)
			{
				score.score += 2;
				count.count +=0.5f;
			}
			else
			{
				score.score += 1;
				count.count +=0.5f;
			}
		}
		
		if(this.gameObject.tag == "Purple" && other.gameObject.tag == "Purple")
		{
			Destroy(gameObject);
			comboColor.comboColor = 5;
			
			if(comboColor.comboColor == 5)
			{
				score.score += 2;
				count.count +=0.5f;
			}
			else
			{
				score.score += 1;
				count.count +=0.5f;
			}
		}
		
	}
	
	
}