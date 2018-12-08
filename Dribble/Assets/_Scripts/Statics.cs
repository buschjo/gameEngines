using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statics : MonoBehaviour {
	public static string selectedCharacter;

	void Start () {
		ApplicationController.Instance.character = selectedCharacter;
	}

	public void chooseFemale(){
		selectedCharacter = "female";
	}

	public void chooseNB(){
		selectedCharacter = "non-binary";
	}

	public void chooseMale(){
		selectedCharacter = "male";
	}

	#if UNITY_EDITOR
     void Update()
     {
        //selectedCharacter = "female";
     }
 	#endif
}
