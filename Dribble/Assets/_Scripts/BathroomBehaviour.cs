using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BathroomBehaviour : MonoBehaviour {

	GameObject maleIcon;
	GameObject femaleIcon;
	GameObject nbIcon;

	// Use this for initialization
	void Start () {

	}

	void OnMouseDown ()
    { 
		maleIcon = GameObject.FindGameObjectWithTag("maleBathroom");
		femaleIcon = GameObject.FindGameObjectWithTag("femaleBathroom");
		nbIcon = GameObject.FindGameObjectWithTag("nbBathroom");

		if (ApplicationController.Instance.character == "female" && femaleIcon || nbIcon){
			ApplicationController.Instance.EmptyCup();
		} else {
			print("gameOvaries (female)");
		} 

		if(ApplicationController.Instance.character == "male" && maleIcon || nbIcon){
			ApplicationController.Instance.EmptyCup();
		} else {
			print("gameOvaries (male)");
		}

		if (ApplicationController.Instance.character == "non-binary"){ 
        ApplicationController.Instance.EmptyCup();
		}
		DestroyObject();
		
    }

	void DestroyObject(){
		Destroy(gameObject);
	}
}
