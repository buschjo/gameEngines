using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnDrops : MonoBehaviour {
	ApplicationController controller;
	public GameObject drop;
	public Text timerText;
	private float xLeftBoundary;
    private float xRightBoundary;
	public float timeRemaining;

	void Start () {
		controller = ApplicationController.Instance;
		setBoundaries();
		StartCoroutine(Spawn());
		UpdateTimerText();
	}

	void setBoundaries(){
		float spriteWidth = drop.GetComponent<Renderer>().bounds.extents.x;
		xLeftBoundary = controller.lowerLeftBoundary.transform.position.x+spriteWidth*2;
		xRightBoundary = controller.bathroomAreaUpperLeftBoundary.transform.position.x-spriteWidth*2;
	}


	// void FixedUpdate(){
	// 	timeRemaining -= Time.deltaTime;
	// 	if(timeRemaining < 0){
	// 		timeRemaining = 0;
	// 	}
	// 	UpdateTimerText();
	// }

	IEnumerator Spawn(){
		yield return new WaitForSeconds (2.0f);
		while(controller.isRunning){
			Vector3 spawnPos = new Vector3(Random.Range(xLeftBoundary,xRightBoundary), transform.position.y,0.0f);
			Instantiate(drop, spawnPos, Quaternion.identity);
			yield return new WaitForSeconds(Random.Range(1.0f, 2.0f));
		}
	}

	void UpdateTimerText(){
		timerText.text = "Time Remaining:\n" + Mathf.RoundToInt(timeRemaining);
	}
}
