using UnityEngine;
using System.Collections;

public class BackgroundController : MonoBehaviour {

	//Public variables that we need to access elsewhere.
	//The booleans are used to set the different backgrounds,
	//when the level changes. The GameObject are taken from the Hierachy,
	//and dragged into the inspecter of the element that this script is
	//attached. 
	public GameObject bgn1, bgn2, bgn3;
	public bool b1 = false, b2 = false, b3 = false;


	// Use this for initialization
	void Start (){
	
	}
	
	// Update is called once per frame
	void Update (){

		//Level one - if-statement that listens if the boolean
		//is true - if that's the case, then the background will activate.
		if(b1 == true){
			bgn1.SetActive(true);		
		}
		//Level two, same as above.
		if(b2 == true){
			bgn2.SetActive(true);			
		}
		//Level three, same as above.
		if(b3 == true){
			bgn3.SetActive(true);			
		}	
	}
}
