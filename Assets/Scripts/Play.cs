using UnityEngine;
using System.Collections;

public class Play : MonoBehaviour {

	public string Level;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	

	}

	void OnMouseUp () {


			Application.LoadLevel (Level);
		Debug.Log ("click");

				
		}


}
