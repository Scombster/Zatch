using UnityEngine;
using System.Collections;

public class Level : MonoBehaviour {

	public float count = 0.0f;
	public bool win = false;
	public bool loss = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		print(count);

		if (count == 50.0f)
		{
			win = true;
			count = 0.0f;
		}

		if (loss == true)
		{
			guiText.text = "GAME OVER";
		}

		if (win == true)
		{
			guiText.text = "YOU WIN!";
		}
			
	}
}
