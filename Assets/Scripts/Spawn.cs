using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {

	public Falling[] blocks;
	public Falling activeBlock;



	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		if ((activeBlock == null) || (activeBlock.enabled == false))
						SpawnBlock ();
	}

	void SpawnBlock(){
		activeBlock = (Falling)Instantiate(blocks[Random.Range(0, blocks.Length)], new Vector3 (0, 15, 0), Quaternion.identity);
	}
}

//testing comment 