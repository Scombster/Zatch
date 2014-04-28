using UnityEngine;
using System.Collections;

public class Play : MonoBehaviour {

	public string Level;
	public AudioClip clip;

	// Use this for initialization
	void Start () {
	
		Time.timeScale = 0f;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseUp () {
		
		audio.PlayOneShot(clip, 0.5F);
		Application.LoadLevel (Level);
		Time.timeScale = 0.1f;
					
		}


}
