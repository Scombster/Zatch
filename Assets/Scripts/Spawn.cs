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
		 	

		if (Time.time > 0.2f) {
			if ((activeBlock == null) || (activeBlock.enabled == false)) {
				SpawnBlock ();
				Time.timeScale = 1f;
			
			}
		}
	}

	void SpawnBlock(){


			if (startGame == false) {
					activeBlock = (Instantiater)Instantiate (spawnBrick, new Vector3 (-1.99f, 8.69f, 0), Quaternion.identity);
					

			} else {
				activeBlock = (Instantiater)Instantiate (spawnBrick, new Vector3 (-1.99f, 8.69f, 0), Quaternion.identity);
				}
	}
}

