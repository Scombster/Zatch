using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {

	public Instantiater spawnBrick;
	public Instantiater activeBlock;
	private bool startGame = true;



	void Start (){
			
	}

	// Update is called once per frame - duh ;)
	void Update (){
		 	
		//This if-statement will check whether there's no activeBlock
		//or if the SpawnedBlock isn't enabled anymore. (Because of a 
		//collision)
		if (Time.time > 0.2f){
			if ((activeBlock == null) || (activeBlock.enabled == false)) {
				SpawnBlock ();
				Time.timeScale = 1f;			
			}
		}
	}

	//Function for spawning a spawnBrick that contains the 
	//coloured bricks. 
	void SpawnBlock(){

		if (startGame == false) {
			activeBlock = (Instantiater)Instantiate (spawnBrick, new Vector3 (-1.99f, 8.69f, 0), Quaternion.identity);
		} else {
			activeBlock = (Instantiater)Instantiate (spawnBrick, new Vector3 (-1.99f, 8.69f, 0), Quaternion.identity);
		}
	}
}

