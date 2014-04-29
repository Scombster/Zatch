using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

	//Public float used to target the tranform via the 
	//inspector-tool. 
	public Transform target;

	//Private float used by the hard-drop, this is 
	//not working perfectly tho.
	private float speed = 100;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		//If-statements used for controlling the spawnBrick. 
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
			
			//##INFO## Useless because it is heading for 
			//the bottomlayer's middle everytime :(
			//Workaround needed, this will do for the moment tho.
			float step = speed * Time.deltaTime;
			transform.position = Vector3.MoveTowards(transform.position, target.position, step);
			//More simple Fastdrop, but will always go 15 down no matter were it is, so can move out of the field. 
			//transform.position += new Vector3(0,-15f,0);
		}
		//Deletes the current spawnBrick, this is 
		//used as sometiems the collider on the spawnBrick
		//will do "funny"-stuff and not collide the way it should.
		//NAUGHTY COLLIDER!!!
		if (Input.GetKey (KeyCode.Delete)) {
			Destroy (gameObject);
		}
	}
}
