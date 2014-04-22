using UnityEngine;
using System.Collections;

public class TimeController : MonoBehaviour {
	
	private float time = 60.0f;
	
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
			guiText.text = "GAME OVER! / NEXT LEVEL!";
		}
		
	}
}

