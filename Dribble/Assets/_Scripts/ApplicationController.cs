using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ApplicationController : Singleton<ApplicationController> {

	[SerializeField]
	float startTime;
	private float remainingTime;
	public int score;
	public string character;
	public Text scoreText;
    public GameObject lowerLeftBoundary;
	public GameObject upperRightBoundary;
	public GameObject bathroomAreaUpperLeftBoundary;


    // Use this for initialization
    void Start () {}

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
}
