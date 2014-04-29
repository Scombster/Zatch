using UnityEngine;
using System.Collections;

public class LevelDisplay : MonoBehaviour {

	private TimeController level;
	private float width = 0 + (Screen.width/5);

	// Use this for initialization
	void Start () {
		level = GameObject.Find("Timer").GetComponent<TimeController>();
		guiText.fontSize = 20;
		//guiText.pixelOffset = new Vector2 (Screen.width/2 -300, Screen.height/2 -275);
		guiText.pixelOffset = new Vector2 (width, Screen.height/2 -275);
	}

	// Update is called once per frame
	void Update () {

		if (level.level == 1) {
			guiText.text = "1";
		}

		if (level.level == 2) {
			guiText.text = "2";
		}

		if (level.level == 3) {
			guiText.text = "3";
		}
	
	}
}
