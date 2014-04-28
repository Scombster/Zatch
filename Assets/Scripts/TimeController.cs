using UnityEngine;
using System.Collections;

public class TimeController : MonoBehaviour {

	//Setting public varibles that we need to access.
	public BackgroundController bgcont;
	public Instantiater speed;
	public bool hasWon = false;
	public string Gameover;


	//Private variables that doesn't need to be accessed by other scripts
	private float time = 20.0f;
	private bool l1 = false, l2 = false, l3 = false;

	// Use this for initialization
	void Start () {
		bgcont.b1 = true;
		l1 = true;
	}
	
	// Update is called once per frame
	void Update () 
	{
		//Outputting the Time remaining on the gamescreen.
		guiText.text = "Time Remaining: " + (int)time;

		//Our first if-statement that checks if we are on level 1.
		if(l1 == true){
			time -= Time.deltaTime;
			if(time < 0 && l1 == true){
				l1 = false;
				l2 = true;
				time = 10.0f;
				speed.Speedlevel = 2.0f;
			}
		}
		//Second if-statement that check wheter we are on level 2.
		if(l2 == true){
			time -= Time.deltaTime;
			bgcont.b2 = true;
			if(time < 0 && l2 == true){
				l2 = false;
				l3 = true;
				time = 10.0f;
				speed.Speedlevel = 10.0f;
			}
		}
		//
		if(l3 == true){
			time -= Time.deltaTime;
			bgcont.b3 = true;
			if(time < 0 && l3 == true){
				hasWon = true;
				Application.LoadLevel ("WinScreen");
				//Debug.Log("l3 if-statement trigged");

			}
		}
	}
}

