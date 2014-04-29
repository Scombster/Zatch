using UnityEngine;
using System.Collections;

public class ScoreController : MonoBehaviour {

	public float count = 0;
	public int score = 0;
	public int comboColor = 0;
	public bool hasGameover = false;
	//We need to access the two booleans hasWon and hasGameover
	public TimeController tc;

	// Use this for initialization
	void Start() 
	{
		guiText.pixelOffset = new Vector2 (250, 220);
		guiText.fontSize = 20;
		guiText.color = Color.white;
	}
	
	// Update is called once per frame
	void Update() 
	{
		//Doing pretty stuff. 
		guiText.text = " " + score;


		//If-statement looking for hasWon or hasGameover
		//conditions. 
		if (tc.hasWon == true || hasGameover == true){
			guiText.pixelOffset = new Vector2(-25, 0);
			guiText.color = Color.black;
		}
		//Keeping the score, so that we can
		//display it on the win, and gameover screen. 
		DontDestroyOnLoad(transform.gameObject);

	}
}
