using UnityEngine;
using System.Collections;

public class ScoreController : MonoBehaviour {

	public float count = 0;
	public int score = 0;
	public int comboColor = 0;
	public TimeController tc;
	public bool hasGameover = false;



	// Use this for initialization
	void Awake () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		guiText.color = Color.white;
		guiText.text = " " + score;
		guiText.fontSize = 20;
		if (tc.hasWon == true || hasGameover == true){
			guiText.pixelOffset = new Vector2(-25, 0);
			guiText.color = Color.black;
		}

		DontDestroyOnLoad(transform.gameObject);

	}
}
