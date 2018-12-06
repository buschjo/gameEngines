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
		print(selectedCharacter);
	}

	public void chooseNB(){
		selectedCharacter = "non-binary";
		print(selectedCharacter);
	}

	public void chooseMale(){
		selectedCharacter = "male";
		print(selectedCharacter);
	}
}
