using UnityEngine;
using System.Collections;

public class ComboText : MonoBehaviour {
	
	private ScoreController comboColor;

	// Use this for initialization
	void Start () {
		comboColor = GameObject.Find("Score").GetComponent<ScoreController>();
	}
	
	// Update is called once per frame
	void Update () {

		comboColor = GameObject.Find("Score").GetComponent<ScoreController>();

		switch (comboColor.comboColor) 
		{
				case 0:
						guiText.text = "No Combo";
						guiText.color = Color.blue;
						break;

				case 1:
						guiText.text = "BLUE COMBO!";
						guiText.color = Color.blue;
						break;

				case 2:
						guiText.text = "GREEN COMBO!";
						guiText.color = Color.green;
						break;

				case 3:
						guiText.text = "ORANGE COMBO!";
						guiText.color = Color.magenta;
						break;

				case 4:
						guiText.text = "YELLOW COMBO!";
						guiText.color = Color.yellow;
						break;

				case 5:
						guiText.text = "PURPLE COMBO!";
						guiText.color = Color.red;
						break;
		}

		/*
		if(comboBlue.comboBlue > 0)
		{
			guiText.text = "BLUE COMBO!";
			guiText.color = Color.blue;
		}
		
		else
		{
			guiText.text = "No Combo";
			guiText.color = Color.white;
		}
		
		if(comboGreen.comboGreen > 0)
		{
			guiText.text = "GREEN COMBO!";
			guiText.color = Color.green;
		}
		
		else
		{
			guiText.text = "No Combo";
			guiText.color = Color.white;
		}
		
		if(comboOrange.comboOrange > 0)
		{
			guiText.text = "ORANGE COMBO!";
			guiText.color = Color.magenta;
		}
		
		else
		{
			guiText.text = "No Combo";
			guiText.color = Color.white;
		}
		
		if(comboYellow.comboYellow > 0)
		{
			guiText.text = "YELLOW COMBO!";
			guiText.color = Color.yellow;
		}
		
		else
		{
			guiText.text = "No Combo";
			guiText.color = Color.white;
		}
		
		if(comboPurple.comboPurple > 0)
		{
			guiText.text = "PURPLE COMBO!";
			guiText.color = Color.red;
		}
		
		else
		{
			guiText.text = "No Combo";
			guiText.color = Color.white;
		}
		*/
	}
}

