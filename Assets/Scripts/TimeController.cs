using UnityEngine;
using System.Collections;

public class TimeController : MonoBehaviour {

	private BackgroundController bgcont;


	private Level loss;
	private float time = 10.0f;

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
			loss.loss = true;
		}
		
	}
}

