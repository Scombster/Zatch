using UnityEngine;
using System.Collections;

public class Instantiater : MonoBehaviour {

	//Array that holds the coloured blocks
	public GameObject[] blocks;
	//GameObjects for the different spawns needed 
	public GameObject b1;
	public GameObject b2;
	public GameObject b3;
	public AudioClip hit;

	//1
	float MoveCD = 0f;
	public	float Speedlevel = 0.5f;


	void Start () {
	
		CreateBlock();

	}
	
	// Update is called once per frame
	void Update () {
		//2
		if (MoveCD < Time.time && this.enabled == true)
		{
			transform.position += new Vector3(0, -1, 0);
			Move ();
		}


		if(b1.gameObject.GetComponent<Collide>().hasHitSomething == true || b2.gameObject.GetComponent<Collide>().hasHitSomething == true || b3.gameObject.GetComponent<Collide>().hasHitSomething == true){

			GetComponent<Controller>().enabled = false;
			this.enabled = false;

		}



	}

	void CreateBlock(){

		//The basic idea here is to have different if-statements that will see if the high-score
		//reaches a certain amount, and then change the amount of spawn bricks acordenly.


		b1 = Instantiate((blocks[Random.Range(0, blocks.Length)]).gameObject, new Vector3 (-0.99f, 8.69f, 0), Quaternion.identity) as GameObject;
		b2 = Instantiate((blocks[Random.Range(0, blocks.Length)]).gameObject, new Vector3 (-1.99f, 8.69f, 0), Quaternion.identity) as GameObject;
		b3 = Instantiate((blocks[Random.Range(0, blocks.Length)]).gameObject, new Vector3 (-2.99f, 8.69f, 0), Quaternion.identity) as GameObject;
	
		b1.transform.parent = this.gameObject.transform;
		b2.transform.parent = this.gameObject.transform;
		b3.transform.parent = this.gameObject.transform;




	}



	void OnCollisionEnter2D(Collision2D collision){

	}

	
	void Move()
	{
		MoveCD = Speedlevel + Time.time;
		
	}



}
