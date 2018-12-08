using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ApplicationController : Singleton<ApplicationController> {

	[SerializeField]
	public int cupFillAmount;
	public int maxCapacity = 10;
	public int gameScore;
	public Text scoreText;
    public GameObject lowerLeftBoundary;
	public GameObject upperRightBoundary;
	public GameObject bathroomAreaUpperLeftBoundary;
	public string character;
	public bool isRunning;

    // Use this for initialization
    void Start () {
		isRunning = true;
	}

	public void IncreaseScore(){
		cupFillAmount++;
		gameScore++;
		UpdateScore();
	}

	void UpdateScore(){
		scoreText.text = "Score:" + gameScore + "\n Capacity: " + cupFillAmount + "/" + maxCapacity;
	}

	public void EmptyCup(){
		cupFillAmount = 0;
		UpdateScore();
	}
}
