using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplicationController : Singleton<ApplicationController> {

	[SerializeField]
	float startTime;
	private float remainingTime;
	private int score;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void increaseScore(){
		score++;
	}


}
