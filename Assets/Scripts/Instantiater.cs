using UnityEngine;
using System.Collections;

public class Instantiater : MonoBehaviour {

	//Array that holds the coloured blocks
	public BrickCont[] blocks;
	//GameObjects for the different spawns needed 
	public GameObject b1;
	public GameObject b2;
	public GameObject b3;


		void Start () {
	
		//I guess this will be just fine leaving like this
		CreateBlock();

	}
	
	// Update is called once per frame
	void Update () {


	}

	void CreateBlock(){

		//The basic idea here is to have different if-statements that will see if the high-score
		//reaches a certain amount, and then change the amount of spawn bricks acordenly.


		b1 = Instantiate((blocks[Random.Range(0, blocks.Length)]).gameObject, new Vector3 (-1.99f, 10.69f, 0), Quaternion.identity) as GameObject;
		b2 = Instantiate((blocks[Random.Range(0, blocks.Length)]).gameObject, new Vector3 (-2.99f, 10.69f, 0), Quaternion.identity) as GameObject;
		b3 = Instantiate((blocks[Random.Range(0, blocks.Length)]).gameObject, new Vector3 (-3.99f, 10.69f, 0), Quaternion.identity) as GameObject;
	
		b1.transform.parent = this.gameObject.transform;
		b2.transform.parent = this.gameObject.transform;
		b3.transform.parent = this.gameObject.transform;
		



	}
}
