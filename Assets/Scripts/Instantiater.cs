using UnityEngine;
using System.Collections;

public class Instantiater : MonoBehaviour {
	//Public's cause we need to access theese elsewhere. 
	//Array that holds the coloured blocks
	public GameObject[] blocks;
	//GameObjects for the different spawns needed 
	public GameObject b1;
	public GameObject b2;
	public GameObject b3;
	//AudioClip
	public AudioClip hit;
	//This will, at some point, be used to control the speed. 
	public	float Speedlevel = 5.0f;

	//Private float that is used to controll the movement
	//of the spawnBrick.
	//##INFO## not working as inteded.
	private float MoveCD = 3f;

	void Start (){
		//This is calling the CreateBlock-function that will instantiate 
		//three lovely blocks. 
		CreateBlock();
	}
	
	// Update is called once per frame
	void Update (){

		//WIP
		if (MoveCD < Time.time && this.enabled == true){
			//Invoke("leveldelay",10);
			transform.position += new Vector3(0, -1, 0);
			Move();
			//Debug.Log("If-statement triggered! : Update@31");
		}


		if(b1.gameObject.GetComponent<Collide>().hasHitSomething == true || b2.gameObject.GetComponent<Collide>().hasHitSomething == true || b3.gameObject.GetComponent<Collide>().hasHitSomething == true){

			audio.PlayOneShot(hit);
			GetComponent<Controller>().enabled = false;
			this.enabled = false;
		}
	}

	void CreateBlock(){

		//Creating 3 bricks, picked randomly. 
		//The problem is that two blue-bricks can
		//spawn next to each other. Which isn't very smart - collider-wise. 
		b1 = Instantiate((blocks[Random.Range(0, blocks.Length)]).gameObject, new Vector3 (-0.99f, 8.69f, 0), Quaternion.identity) as GameObject;
		b2 = Instantiate((blocks[Random.Range(0, blocks.Length)]).gameObject, new Vector3 (-1.99f, 8.69f, 0), Quaternion.identity) as GameObject;
		b3 = Instantiate((blocks[Random.Range(0, blocks.Length)]).gameObject, new Vector3 (-2.99f, 8.69f, 0), Quaternion.identity) as GameObject;
		//Making the newly instantiated bricks children of our spawnBrick. 
		b1.transform.parent = this.gameObject.transform;
		b2.transform.parent = this.gameObject.transform;
		b3.transform.parent = this.gameObject.transform;
	}

	//WIP
	void Move()
	{
		MoveCD = Speedlevel + Time.time;		
	}

	//WIP 
	/*
	void leveldelay(){
		transform.position += new Vector3(0, -1, 0);
		Debug.Log("ost");
	}
	*/
}
