using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ApplicationController : Singleton<ApplicationController> {

	[SerializeField]
	float startTime;
	private float remainingTime;
	public int score;
	public float gameAreaWidth;
	public float bathroomAreaWidth;
	public Camera cam; 
	public Text scoreText; 
	public string character;

	// Use this for initialization
	void Start () {
		if(cam == null){
			cam = Camera.main;
		}
		bathroomAreaWidth = 5;
		gameAreaWidth = ExtractDropAreaWidth();

	}

	public void IncreaseScore(){
		score++;
		UpdateScore();
	}

	void UpdateScore(){
		scoreText.text = "Score:\n" + ApplicationController.Instance.score;
	}

	public void EmptyCup(){
		score = 0;
		UpdateScore();
	}

	public float ExtractDropAreaWidth(){
		Vector3 upperCorner = new Vector3(Screen.width, Screen.height, 0.0f);
		return cam.ScreenToWorldPoint(upperCorner).x;
	}

}
