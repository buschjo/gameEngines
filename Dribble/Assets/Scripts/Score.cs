using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Text scoreText;
	public int amountOfDrops;
	private int score;

	// Use this for initialization
	void Start () {
		score = 0;
		UpdateScore();
	}

	void OnTriggerEnter2D(){
		score += amountOfDrops;
		UpdateScore();
	}

	void UpdateScore(){
	scoreText.text = "Score:\n" + score;
	}

}
