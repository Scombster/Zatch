using UnityEngine;
using System.Collections;

public class ComboText : MonoBehaviour {

	private ScoreController comboColor;
	public AudioClip comboClip;
	public bool combo = false;

	// Use this for initialization
	void Start () {
		comboColor = GameObject.Find("Score").GetComponent<ScoreController>();
	}
	
	// Update is called once per frame
	void Update () {

		if( combo == true)
		{
			audio.PlayOneShot(comboClip, 0.5F);
			Debug.Log("click");
		}

		switch (comboColor.comboColor) 
		{
				case 0:
						guiText.text = "No Bonus";
						guiText.color = Color.white;
						break;

				case 1:
						guiText.text = "BLUE GIVES DOUBLE!";
						guiText.color = Color.blue;
						break;

				case 2:
						guiText.text = "GREEN GIVES DOUBLE!";
						guiText.color = Color.green;
						break;

				case 3:
						guiText.text = "ORANGE GIVES DOUBLE!";
						guiText.color = new Color32(255, 140, 0, 255);
						break;

				case 4:
						guiText.text = "YELLOW GIVES DOUBLE!";
						guiText.color = Color.yellow;
						break;

				case 5:
						guiText.text = "PURPLE GIVES DOUBLE!";
						guiText.color = new Color32(128, 0, 128, 255);
						break;
		}
	}
}

