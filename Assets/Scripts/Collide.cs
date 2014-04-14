using UnityEngine;
using System.Collections;

public class Collide : MonoBehaviour {

	int score;


	// Use this for initialization
	void Start () {
	


	
	
	}
	
	// Update is called once per frame
	void Update () {
	
				if (Input.GetKey (KeyCode.Delete)) {
						Destroy (gameObject);
				}

		//Start of tracking and displaying Score
		//guiText.text = "This is the Score";
	}

	//Collision between objects with same tag
	void OnCollisionEnter(Collision other){
			
			if(other.gameObject.tag == "Blue"){
				
				Destroy(gameObject);
				score++;
			}
		}

		
}
