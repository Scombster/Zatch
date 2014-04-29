using UnityEngine;
using System.Collections;

public class LevelDisplay : MonoBehaviour {

	private TimeController level;

	// Use this for initialization
	void Start () {
		Screen.SetResolution (800, 600, false);
		level = GameObject.Find("Timer").GetComponent<TimeController>();
		guiText.fontSize = 20;
		guiText.pixelOffset = new Vector2(250, -100);
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
