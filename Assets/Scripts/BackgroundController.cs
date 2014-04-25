using UnityEngine;
using System.Collections;

public class BackgroundController : MonoBehaviour {

	public GameObject bgn1, bgn2, bgn3;


	public bool b1 = false, b2 = false, b3 = false;


	void Awake(){
	

		bgn1.SetActive(true);
		bgn2.SetActive(false);
		bgn3.SetActive(false);
	}



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		if(b1 == true){
			bgn1.SetActive(!bgn1.activeSelf);
		
		}
		
		if(b2 == true){
			bgn2.SetActive(!bgn2.activeSelf);
			
		}
		
		if(b3 == true){
			bgn3.SetActive(!bgn3.activeSelf);
			
		}


	
	}
	


}
