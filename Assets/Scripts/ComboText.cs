using UnityEngine;
using System.Collections;

public class ComboText : MonoBehaviour {

	//Public variables that we need to use elsewhere, in this
	//case the inspector.
	//##INFO## the bool combo could might as well be private guys
	public AudioClip comboClip;
	public bool combo = false;

	//Private comboColor used to access the comboColor int from
	//the ScoreController
	//##INFO## is this even being used???
	private ScoreController comboColor;


	// Use this for initialization
	void Start () {
		comboColor = GameObject.Find("Score").GetComponent<ScoreController>();
		guiText.pixelOffset = new Vector2 (Screen.width/2 -300, Screen.height/2 -200);
	}
	
	// Update is called once per frame
	void Update () {
		//Setting font size
		guiText.fontSize = 20;
		//Looks after combos, if any - a sound will be played
		if(combo == true){
			audio.PlayOneShot(comboClip, 0.5F);
			//Debug.Log("ComboText - combo == true @ if-statement");
		}

		//Switch-case that changes the colors.
		switch (comboColor.comboColor){
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

