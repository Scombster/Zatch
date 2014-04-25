using UnityEngine;
using System.Collections;

public class TimeController : MonoBehaviour {

<<<<<<< HEAD
	private BackgroundController bgcont;


	private Level loss;
	private float time = 10.0f;
=======
	private Level win; 
	private float time = 60.0f;
>>>>>>> 5d78f3a1f3e5495c7f2c148e9b5085eb694589cb

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		time -= Time.deltaTime;
		
		if(time > 0)
		{
			guiText.text = "Time Remaining: " + (int)time;

		}
		else
		{
			win.win = true;
		}
		
	}
}

