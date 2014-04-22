using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {
	//This is part of harddrop
	//Target pointing to ButtomLayer
	//public Transform target;
	//Hard drop speed
	//float hardSpeed = 1.5f;






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
		if(Input.GetKey("down")){
			transform.position += new Vector3(0,-1f,0);
		}
		if(Input.GetKeyDown("space")){
			//hard drop, just an idea to use MoveTowards
			//transform.position = Vector3.MoveTowards(transform.position, target.position, hardSpeed*Time.deltaTime);

			//Simple Harddrop mechanic
			transform.position += new Vector3(0,-15f,0);
		}

		//"Resets" the game by destroying all bricks
		if (Input.GetKey (KeyCode.Delete)) {
			Destroy (gameObject);
		}


	}

}
