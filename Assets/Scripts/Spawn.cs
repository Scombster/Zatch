using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {

	public Instantiater spawnBrick;
	public Instantiater activeBlock;
	private bool startGame = true;



	void Start () {
		//This is just here to spawn a single "SpawnBrick"
		//SpawnBlock ();
	}
	
	// Update is called once per frame
	void Update () {


		if ((activeBlock == null) || (activeBlock.enabled == false)){
			SpawnBlock ();
		}
	}

	void SpawnBlock(){


			if (startGame == false) {
				//	yield return new WaitForSeconds (4);
					activeBlock = (Instantiater)Instantiate (spawnBrick, new Vector3 (-1.99f, 9.69f, 0), Quaternion.identity);
					startGame = true;

			} else {
				activeBlock = (Instantiater)Instantiate (spawnBrick, new Vector3 (-1.99f, 9.69f, 0), Quaternion.identity);
				}
	}
}

