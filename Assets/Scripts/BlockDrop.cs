using UnityEngine;
using System.Collections;

public class BlockDrop : MonoBehaviour {

	IEnumerator Start() {
		while (true) {
			yield return new WaitForSeconds(1);
			transform.Translate(0,-1,0);
		}
	}
}
