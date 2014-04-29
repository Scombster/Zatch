using UnityEngine;
using System.Collections;

public class TimeController : MonoBehaviour {

	//Setting public varibles that we need to access.
	public BackgroundController bgcont;
	public Instantiater speed;
	public bool hasWon = false;
	public string Gameover;


	//Private variables that doesn't need to be accessed by other scripts
	private float time = 60.0f;
	public int level = 0;

	// Use this for initialization
	void Start () {
		bgcont.b1 = true;
		level = 1;
		guiText.pixelOffset = new Vector2 (250, 85);
		guiText.fontSize = 20;
	}
	
	// Update is called once per frame
	void Update () 
	

	{
		//Outputting the Time remaining on the gamescreen.
		guiText.text = " " + (int)time;
	
		//Our first if-statement that checks if we are on level 1.
		if(level == 1){
			speed.brickSpeed = 0.5f;
			time -= Time.deltaTime;
			if(time < 0 && level == 1){
				level = 2;
				time = 60.0f;
				speed.Speedlevel = 1.0f;
			}
		}
		//Second if-statement that check wheter we are on level 2.
		if(level == 2){
			speed.brickSpeed = 0.2f;
			time -= Time.deltaTime;
			bgcont.b2 = true;
			if(time < 0 && level == 2){
				level = 3;
				time = 60.0f;
				speed.Speedlevel = 10.0f;
			}
		}
		//
		if(level == 3){
			speed.brickSpeed = 0.050f;
			time -= Time.deltaTime;
			bgcont.b3 = true;
			if(time < 0 && level == 3){
				hasWon = true;
				Application.LoadLevel ("WinScreen");
				//Debug.Log("l3 if-statement trigged");

			}
		}
	}
}

