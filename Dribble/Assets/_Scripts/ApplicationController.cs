using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplicationController : Singleton<ApplicationController> {

	[SerializeField]
	float startTime;
	private float remainingTime;
	private int score;
	public float gameAreaWidth;
	public float dropAreaHeight;
	public float bathroomAreaWidth;
	private float bathroomAreaHeight;
	public Camera cam; 

	// Use this for initialization
	void Start () {
		bathroomAreaWidth = 5;
		if(cam == null){
			cam = Camera.main;
		}
		Vector3 upperCorner = new Vector3(Screen.width, Screen.height, 0.0f);
		Vector3 targetWidth = cam.ScreenToWorldPoint(upperCorner);
		gameAreaWidth = targetWidth.x;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void IncreaseScore(){
		score++;
	}

	// public float ExtractDropAreaWidth(){
	// 	Vector3 upperCorner = new Vector3(Screen.width, Screen.height, 0.0f);
	// 	Vector3 targetWidth = cam.ScreenToWorldPoint(upperCorner);
	// 	float dropWidth = drop.GetComponent<Renderer>().bounds.extents.x;
	// 	Debug.Log("Initial width");
	// 	Debug.Log(targetWidth.x - dropWidth);
	// 	return targetWidth.x - dropWidth;
	// }

}
