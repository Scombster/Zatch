using UnityEngine;
using System.Collections;

public class Collide : MonoBehaviour {

	private ScoreController score;
	private ScoreController comboColor;

	public GameObject[] gameObjectsBlue;
	public GameObject[] gameObjectsGreen;
	public GameObject[] gameObjectsOrange;
	public GameObject[] gameObjectsYellow;
	public GameObject[] gameObjectsPurple;

	public bool hasHitSomething = false;
	public string Gameover;
	private Level count;

	void Start () 
	{
		//Initialzation from the ScoreController script
		score = GameObject.Find("Score").GetComponent<ScoreController>();
		comboColor = GameObject.Find ("Score").GetComponent<ScoreController>();
	}
	
	void Update () 
	{			
		gameObjectsBlue = GameObject.FindGameObjectsWithTag ("Blue");
		gameObjectsGreen = GameObject.FindGameObjectsWithTag ("Green");
		gameObjectsOrange = GameObject.FindGameObjectsWithTag ("Orange");
		gameObjectsYellow = GameObject.FindGameObjectsWithTag ("Yellow");
		gameObjectsPurple = GameObject.FindGameObjectsWithTag ("Purple");
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

			if(this.gameObject.tag == "Blue" && other.gameObject.tag == "Blue" && comboColor.comboColor != 1)
			{
				for(int i = 0; i < gameObjectsBlue.Length; i++)
				{
				Destroy(gameObject);
				score.score += 1;
				comboColor.comboColor = 1;
				}

				count.count += 0.5f;
			}

			if(this.gameObject.tag == "Blue" && other.gameObject.tag == "Blue" && comboColor.comboColor == 1)
			{
				for(int i = 0; i < gameObjectsBlue.Length; i++)
				{
					Destroy(gameObject);
					score.score += 2;
					comboColor.comboColor = 1;
				}
				
				count.count += 0.5f;
			}
		
			if(this.gameObject.tag == "Green" && other.gameObject.tag == "Green" && comboColor.comboColor != 2)
			{
				for(int i = 0; i < gameObjectsGreen.Length; i++)
				{
					Destroy(gameObject);
					score.score += 1;
					comboColor.comboColor = 2;
				}
				
				count.count += 0.5f;
			}
			
			if(this.gameObject.tag == "Green" && other.gameObject.tag == "Green" && comboColor.comboColor == 2)
			{
				for(int i = 0; i < gameObjectsGreen.Length; i++)
				{
					Destroy(gameObject);
					score.score += 2;
					comboColor.comboColor = 2;
				}
				
				count.count += 0.5f;
			}

			if(this.gameObject.tag == "Orange" && other.gameObject.tag == "Orange" && comboColor.comboColor != 3)
			{
				for(int i = 0; i < gameObjectsOrange.Length; i++)
				{
					Destroy(gameObject);
					score.score += 1;
					comboColor.comboColor = 3;
				}
				
				count.count += 0.5f;
			}
			
			if(this.gameObject.tag == "Orange" && other.gameObject.tag == "Orange" && comboColor.comboColor == 3)
			{
				for(int i = 0; i < gameObjectsOrange.Length; i++)
				{
					Destroy(gameObject);
					score.score += 2;
					comboColor.comboColor = 3;
				}
				
				count.count += 0.5f;
			}

			if(this.gameObject.tag == "Yellow" && other.gameObject.tag == "Yellow" && comboColor.comboColor != 4)
			{
				for(int i = 0; i < gameObjectsYellow.Length; i++)
				{
					Destroy(gameObject);
					score.score += 1;
					comboColor.comboColor = 4;
				}
				
				count.count += 0.5f;
			}
			
			if(this.gameObject.tag == "Yellow" && other.gameObject.tag == "Yellow" && comboColor.comboColor == 4)
			{
				for(int i = 0; i < gameObjectsYellow.Length; i++)
				{
					Destroy(gameObject);
					score.score += 1;
					comboColor.comboColor = 4;
				}
				
				count.count += 0.5f;
			}

			if(this.gameObject.tag == "Purple" && other.gameObject.tag == "Purple" && comboColor.comboColor != 5)
			{
				for(int i = 0; i < gameObjectsPurple.Length; i++)
				{
					Destroy(gameObject);
					score.score += 1;
					comboColor.comboColor = 5;
				}
				
				count.count += 0.5f;
			}
			
			if(this.gameObject.tag == "Purple" && other.gameObject.tag == "Purple" && comboColor.comboColor == 5)
			{
				for(int i = 0; i < gameObjectsPurple.Length; i++)
				{
					Destroy(gameObject);
					score.score += 2;
					comboColor.comboColor = 5;
				}
				
				count.count += 0.5f;;
			}
		}
	}
}