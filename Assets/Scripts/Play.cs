using UnityEngine;
using System.Collections;

public class Play : MonoBehaviour {

	public string Level;
	public AudioClip clip;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	

	}

	void OnMouseUp () {

		audio.PlayOneShot(clip, 0.5F);
			Application.LoadLevel (Level);
			Debug.Log ("click");
			


				
		}


}
