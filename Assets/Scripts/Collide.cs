using UnityEngine;
using System.Collections;

public class Collide : MonoBehaviour {

	private ScoreController score;
	public ScoreController comboColor;
	public string Gameover;

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
				if(this.transform.position.y >= 8.69f){
					Debug.Log("Maria");
					Application.LoadLevel ("Gameover");

				}
				//Something needs to tell Instatiater that this object has collided!
				hasHitSomething = true;

				//this is legacy code
			
			}
		}





		if(hasHitSomething == true){

		//Detects collison between bricks. 
		//If the colors match it updates score and destroy the colliding bricks.

			if(this.gameObject.tag == "Blue" && other.gameObject.tag == "Blue")
			{
				Destroy(gameObject);
			
				if(comboColor.comboColor == 1)
				{
					score.score += 2;
					count.count += 0.5f;
				}
				else
				{
					score.score += 1;
					count.count +=0.5f;

					comboColor.comboColor = 1;
				}
			}
		
			if(this.gameObject.tag == "Green" && other.gameObject.tag == "Green")
			{
				Destroy(gameObject);
			
				if(comboColor.comboColor == 2)
				{
					score.score += 2;
					count.count +=0.5f;
				}
				else
				{
					score.score += 1;
					count.count +=0.5f;

					comboColor.comboColor = 2;
				}
			}
		
			if(this.gameObject.tag == "Orange" && other.gameObject.tag == "Orange")
			{
				Destroy(gameObject);
			
				if(comboColor.comboColor == 3)
				{
					score.score += 2;
					count.count +=0.5f;
				}
				else
				{
					score.score += 1;
					count.count +=0.5f;

					comboColor.comboColor = 3;
				}
			}
		
			if(this.gameObject.tag == "Yellow" && other.gameObject.tag == "Yellow")
			{
				Destroy(gameObject);
			
				if(comboColor.comboColor == 4)
				{
					score.score += 2;
					count.count +=0.5f;
				}
				else
				{
					score.score += 1;
					count.count +=0.5f;

					comboColor.comboColor = 4;
				}
			}
		
			if(this.gameObject.tag == "Purple" && other.gameObject.tag == "Purple")
			{
				Destroy(gameObject);

				if(comboColor.comboColor == 5)
				{
					score.score += 2;
					count.count +=0.5f;
				}
				else
				{
					score.score += 1;
					count.count +=0.5f;

					comboColor.comboColor = 5;
				}
			}
		}
	}
}