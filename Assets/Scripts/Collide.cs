using UnityEngine;
using System.Collections;

public class Collide : MonoBehaviour {

	//Public variables that we need to access elsewhere. 
	public int radius = 1;
	public ComboText combo;
	public bool hasHitSomething = false;

	//Private instantiation of the ScoreController
	//##INFO## - One instantiation is enough guys
	//Bear out.
	private ScoreController score;
	private ScoreController comboColor;


	void Start () 
	{
		//Initialzation from the ScoreController script
		score = GameObject.Find("Score").GetComponent<ScoreController>();
		comboColor = GameObject.Find ("Score").GetComponent<ScoreController>();

	}
	
	void Update () 
	{			

	}

	//Used backend for debugging
	void OnDrawGizmos()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere (transform.position, radius);
	}

	//Giant function that checks for collisions, on spawnBricks,
	//and tagged-bricks. 
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
				//This is a workaround we're using to avoid collision detection if 
				//two bricks spawn next to each other.
				hasHitSomething = true;
			}
		}
		
			if(this.gameObject.tag == "Blue" && other.gameObject.tag == "Blue" && comboColor.comboColor != 1)
			{

				Collider2D[] colliders = Physics2D.OverlapCircleAll(other.transform.position, radius);

				foreach(Collider2D col in colliders){
					if(col.tag == "Blue"){
					Destroy(col.gameObject);
					score.score += 1;
					comboColor.comboColor = 1;
					}
				}
			}

			if(this.gameObject.tag == "Blue" && other.gameObject.tag == "Blue" && comboColor.comboColor == 1)
			{

				Collider2D[] colliders = Physics2D.OverlapCircleAll(this.gameObject.transform.position, radius);
				
				foreach(Collider2D col in colliders){
					if(col.tag == "Blue"){
					Destroy(col.gameObject);
					score.score += 2;
					comboColor.comboColor = 1;
					}
				}
			}
		
			if(this.gameObject.tag == "Green" && other.gameObject.tag == "Green" && comboColor.comboColor != 2)
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
			
			if(this.gameObject.tag == "Green" && other.gameObject.tag == "Green" && comboColor.comboColor == 2)
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

			if(this.gameObject.tag == "Orange" && other.gameObject.tag == "Orange" && comboColor.comboColor != 3)
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
			
			if(this.gameObject.tag == "Orange" && other.gameObject.tag == "Orange" && comboColor.comboColor == 3)
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

			if(this.gameObject.tag == "Yellow" && other.gameObject.tag == "Yellow" && comboColor.comboColor != 4)
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
			
			if(this.gameObject.tag == "Yellow" && other.gameObject.tag == "Yellow" && comboColor.comboColor == 4)
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

			if(this.gameObject.tag == "Purple" && other.gameObject.tag == "Purple" && comboColor.comboColor != 5)
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
			
			if(this.gameObject.tag == "Purple" && other.gameObject.tag == "Purple" && comboColor.comboColor == 5)
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