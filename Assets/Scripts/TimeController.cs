using UnityEngine;
using System.Collections;

public class TimeController : MonoBehaviour {


	public BackgroundController bgcont;


	private Level loss;
	private float time = 3.0f;

	private Level win; 


	public string Gameover;

	private bool l1 = false, l2 = false, l3 = false;

	// Use this for initialization
	void Start () {
		bgcont.b1 = true;
		l1 = true;
	}
	
	// Update is called once per frame
	void Update () 
	{



		guiText.text = "Time Remaining: " + (int)time;

		if(l1 == true){
			time -= Time.deltaTime;
			if(time < 0 && l1 == true){
				l1 = false;
				l2 = true;
				time = 5.0f;
			}
		}
		if(l2 == true){
			time -= Time.deltaTime;
			bgcont.b2 = true;
			if(time < 0 && l2 == true){
				l2 = false;
				l3 = true;
				time = 7.0f;
			}

		}
		if(l3 == true){
			time -= Time.deltaTime;
			bgcont.b3 = true;
			if(time < 0 && l3 == true){
				Application.LoadLevel (Gameover);
				Debug.Log("kage");
			}
		}
	}
}

