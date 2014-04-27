using UnityEngine;
using System.Collections;

public class Level : MonoBehaviour {

	public float count = 0.0f;
	public bool win = false;
	public bool loss = false;
	public string Gameover;
	public GameObject Background_picture;

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
			Application.LoadLevel (Gameover);
			Debug.Log ("click");
		}
		
	}
}
