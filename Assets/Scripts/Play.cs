using UnityEngine;
using System.Collections;

public class Play : MonoBehaviour {

	public string Level;
	public AudioClip clip;

	// Use this for initialization
	void Start (){
		//Small hack to delay the spawn of 
		//the first brick. 
		Time.timeScale = 0f;
	}
	
	// Update is called once per frame
	void Update (){
	
	}

	void OnMouseUp (){
		//Playing audio clip, loading the scene "Level" and adjusting
		//the timeScale. :)
		audio.PlayOneShot(clip, 0.5F);
		Application.LoadLevel (Level);
		Time.timeScale = 0.1f;
					
	}
}
