using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {
	
	//Controlling how fast the keyDown will be.
	private float lastDown, timeBetweenDowns = 0.5f;
	public float speed;
	public Transform target;
	
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
			
			
			float step = speed * Time.deltaTime;
			transform.position = Vector3.MoveTowards(transform.position, target.position, step);
			
			//transform.position += new Vector3(0,-15f,0);
		}
		
		//"Resets" the game by destroying all bricks
		if (Input.GetKey (KeyCode.Delete)) {
			Destroy (gameObject);
		}
		
	}
	
}
