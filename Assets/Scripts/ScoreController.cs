using UnityEngine;
using System.Collections;

public class ScoreController : MonoBehaviour {

	public float count = 0;
	public int score = 0;
	public int comboColor = 0;

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
