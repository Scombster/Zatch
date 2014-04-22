using UnityEngine;
using System.Collections;

public class ScoreController : MonoBehaviour {
	
	public int score = 0;
	public int comboBlue = 0;
	public int comboGreen = 0;
	public int comboOrange = 0;
	public int comboYellow = 0;
	public int comboPurple = 0;
	
	// Use this for initialization
	void Awake () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		guiText.text = "Score: " + score;
		
	}
}
