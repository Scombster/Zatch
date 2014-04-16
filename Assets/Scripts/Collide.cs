using UnityEngine;
using System.Collections;

public class Collide : MonoBehaviour {

	private ScoreController score;

	// Use this for initialization
	void Start () 
	{
		score = GameObject.Find("Score").GetComponent<ScoreController>();	
	}
	
	// Update is called once per frame
	void Update () 
	{			

		if (Input.GetKey (KeyCode.Delete)) 
		{
			Destroy (gameObject);
		}
		
	}

	//Collision and score update between objects with same tag
	void OnCollisionEnter2D(Collision2D other)
	{
			
		if(this.gameObject.tag == "Blue" && other.gameObject.tag == "Blue")
		{
			Destroy(gameObject);
			score.score += 1;
		}

		if(this.gameObject.tag == "Green" && other.gameObject.tag == "Green")
		{
			Destroy(gameObject);
			score.score += 1;
		}

		if(this.gameObject.tag == "Orange" && other.gameObject.tag == "Orange")
		{
			Destroy(gameObject);
			score.score += 1;
		}

		if(this.gameObject.tag == "Yellow" && other.gameObject.tag == "Yellow")
		{
			Destroy(gameObject);
			score.score += 1;
		}

		if(this.gameObject.tag == "Purple" && other.gameObject.tag == "Purple")
		{
			Destroy(gameObject);
			score.score += 1;
		}

	}

		
}
