using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {

	public GameObject spawnBrick;
	public Controller activeBlock;




	void Start () {
		//This is just here to spawn a single "SpawnBrick"
		SpawnBlock ();
	}
	
	// Update is called once per frame
	void Update () {



		//This if-statement doesn't work yet since it doesn't track the
		//active "spawnBrick" wich should be set to activeBlock.
		//This is very urgent!!!
		/*
		if ((activeBlock == null) || (activeBlock.enabled == false)){
			SpawnBlock ();
		}

		*/
	}

	void SpawnBlock(){
		activeBlock = (Controller)Instantiate(spawnBrick,new Vector3 (-1.99f, 10.69f, 0), Quaternion.identity);

	}
}

