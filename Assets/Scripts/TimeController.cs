using UnityEngine;
using System.Collections;

public class TimeController : MonoBehaviour {


	private BackgroundController bgcont;


	private Level loss;
	private float time = 100.0f;

	private Level win; 
	private BackgroundController b1;
	private BackgroundController b2;
	private BackgroundController b3;

	public string Gameover;


	// Use this for initialization
	void Start () {
		//b1 = GameObject.Find("b1").GetComponent<BackgroundController>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		time -= Time.deltaTime;
		
		if(time > 0 && b1.b1 == true)
		{
			guiText.text = "Time Remaining: " + (int)time;

		}
		else
		{
			b2.b2 = true;
			b1.b1 = false;
			time = 100.0f;
		}
			if(time > 0 && b2.b2 == true)
			{
				guiText.text = "Time Remaining: " + (int)time;
			}
			else
			{
				b3.b3 = true;
				b2.b2 = false;
				time = 100.0f;
			}
			if(time > 0 && b3.b3 == true)
			{
				guiText.text = "Time Remaining: " + (int)time;
			}
			else
			{
				Application.LoadLevel (Gameover);
				Debug.Log ("click");
			}
	}
}

