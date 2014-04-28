using UnityEngine;
using System.Collections;

public class Collide : MonoBehaviour {

	private ScoreController score;
	private ScoreController comboColor;

<<<<<<< HEAD
	public int radius = 1;
=======

	public float radius = 1000.0f;
>>>>>>> bea1448eb63be93468c0c26ad1995b3068455475

	public ComboText combo;

	//public GameObject[] gameObjectsBlue;
	public GameObject[] gameObjectsGreen;
	public GameObject[] gameObjectsOrange;
	public GameObject[] gameObjectsYellow;
	public GameObject[] gameObjectsPurple;

	public bool hasHitSomething = false;


	void Start () 
	{
		//Initialzation from the ScoreController script
		score = GameObject.Find("Score").GetComponent<ScoreController>();
		comboColor = GameObject.Find ("Score").GetComponent<ScoreController>();

	}
	
	void Update () 
	{			

		//gameObjectsBlue = GameObject.FindGameObjectsWithTag ("Blue");
		gameObjectsGreen = GameObject.FindGameObjectsWithTag ("Green");
		gameObjectsOrange = GameObject.FindGameObjectsWithTag ("Orange");
		gameObjectsYellow = GameObject.FindGameObjectsWithTag ("Yellow");
		gameObjectsPurple = GameObject.FindGameObjectsWithTag ("Purple");
		print (collidersBlue.Length);
	}

	void OnDrawGizmos(){
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere (transform.position, radius);
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
					score.hasGameover = true;
					Application.LoadLevel ("Gameover");

				}

				//Something needs to tell Instatiater that this object has collided!
				hasHitSomething = true;
			}
		}

	//}

	//void OnTriggerEnter2D(Collider2D other){
		
			if(this.gameObject.tag == "Blue" && other.gameObject.tag == "Blue" && comboColor.comboColor != 1)
			{
				print ("Blue Collide 1");

				//for(int i = 0; i < gameObjectsBlue.Length; i++){

					print ("Blue Collide 2");

					Collider2D[] collidersBlue = Physics2D.OverlapCircleAll(other.transform.position, radius);

					print (collidersBlue.Length);
					print (this.gameObject.transform.position);
					foreach(Collider2D col in collidersBlue){
						print ("Blue Collide 3");
						if(col.collider2D.tag == "Blue"){
						Destroy(col.collider2D.gameObject);
						score.score += 1;
						comboColor.comboColor = 1;
						}
					}
				//}
			}

			if(this.gameObject.tag == "Blue" && other.gameObject.tag == "Blue" && comboColor.comboColor == 1)
			{
				
		
				//for(int i = 0; i < gameObjectsBlue.Length; i++)
				//{
					Collider2D[] colliders = Physics2D.OverlapCircleAll(this.gameObject.transform.position, radius);
					
					foreach(Collider2D col in colliders){
						if(col.tag == "Blue"){
						Destroy(col.gameObject);
						score.score += 2;
						comboColor.comboColor = 1;
						}
					}
				//}
			}
		
			if(this.gameObject.tag == "Green" && other.gameObject.tag == "Green" && comboColor.comboColor != 2)
			{
				for(int i = 0; i < gameObjectsGreen.Length; i++)
				{
					Collider2D[] colliders = Physics2D.OverlapCircleAll(this.gameObject.transform.position, radius);	
					
					foreach(Collider2D col in colliders){
						if(col.tag == "Green"){
						Destroy(col.gameObject);
						score.score += 1;
						comboColor.comboColor = 2;
						}
					}	
				}
			}
			
			if(this.gameObject.tag == "Green" && other.gameObject.tag == "Green" && comboColor.comboColor == 2)
			{
				for(int i = 0; i < gameObjectsGreen.Length; i++)
				{
					Collider2D[] colliders = Physics2D.OverlapCircleAll(this.gameObject.transform.position, radius);
					
					foreach(Collider2D col in colliders){
						if(col.tag == "Green"){
						Destroy(col.gameObject);
						score.score += 2;
						comboColor.comboColor = 2;
						}
					}
				}
			}

			if(this.gameObject.tag == "Orange" && other.gameObject.tag == "Orange" && comboColor.comboColor != 3)
			{
				for(int i = 0; i < gameObjectsOrange.Length; i++)
				{
					Collider2D[] colliders = Physics2D.OverlapCircleAll(this.gameObject.transform.position, radius);
					
					foreach(Collider2D col in colliders){
						if(col.tag == "Orange"){
						Destroy(col.gameObject);
						score.score += 1;
						comboColor.comboColor = 3;
						}
					}
				}
			}
			
			if(this.gameObject.tag == "Orange" && other.gameObject.tag == "Orange" && comboColor.comboColor == 3)
			{
				for(int i = 0; i < gameObjectsOrange.Length; i++)
				{
					Collider2D[] colliders = Physics2D.OverlapCircleAll(this.gameObject.transform.position, radius);
					
					foreach(Collider2D col in colliders){
						if(col.tag == "Orange"){
						Destroy(col.gameObject);
						score.score += 2;
						comboColor.comboColor = 3;
						}
					}
				}
			}

			if(this.gameObject.tag == "Yellow" && other.gameObject.tag == "Yellow" && comboColor.comboColor != 4)
			{
				for(int i = 0; i < gameObjectsYellow.Length; i++)
				{
					Collider2D[] colliders = Physics2D.OverlapCircleAll(this.gameObject.transform.position, radius);
					
					foreach(Collider2D col in colliders){
						if(col.tag == "Yellow"){
						Destroy(col.gameObject);
						score.score += 1;
						comboColor.comboColor = 4;
						}
					}
				}
			}
			
			if(this.gameObject.tag == "Yellow" && other.gameObject.tag == "Yellow" && comboColor.comboColor == 4)
			{
				for(int i = 0; i < gameObjectsYellow.Length; i++)
				{
					Collider2D[] colliders = Physics2D.OverlapCircleAll(this.gameObject.transform.position, radius);

					foreach(Collider2D col in colliders){
						if(col.tag == "Yellow"){
						Destroy(col.gameObject);
						score.score += 2;
						comboColor.comboColor = 4;
						}
					}
				}
			}

			if(this.gameObject.tag == "Purple" && other.gameObject.tag == "Purple" && comboColor.comboColor != 5)
			{
				for(int i = 0; i < gameObjectsPurple.Length; i++)
				{
					Collider2D[] colliders = Physics2D.OverlapCircleAll(this.gameObject.transform.position, radius);

					foreach(Collider2D col in colliders){
						if(col.tag == "Purple"){
						Destroy(col.gameObject);
						score.score += 1;
						comboColor.comboColor = 5;
						}
					}
				}
			}
			
			if(this.gameObject.tag == "Purple" && other.gameObject.tag == "Purple" && comboColor.comboColor == 5)
			{
				for(int i = 0; i < gameObjectsPurple.Length; i++)
				{
					Collider2D[] colliders = Physics2D.OverlapCircleAll(this.gameObject.transform.position, radius);

					foreach(Collider2D col in colliders){
						if(col.tag == "Purple"){
						Destroy(col.gameObject);
						score.score += 2;
						comboColor.comboColor = 5;
						}
					}
				}
			}
	}
}