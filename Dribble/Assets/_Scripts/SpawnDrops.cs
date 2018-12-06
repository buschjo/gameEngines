using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnDrops : MonoBehaviour {
	public GameObject drop;
	public Text timerText;
	private float xLeftBoundary;
    private float xRightBoundary;
	public float timeRemaining;

	void Start () {
		setBoundaries();
		StartCoroutine(Spawn());
		UpdateTimerText();
	}

	void setBoundaries(){
		float spriteWidth = drop.GetComponent<Renderer>().bounds.extents.x;
		xLeftBoundary = ApplicationController.Instance.lowerLeftBoundary.transform.position.x+spriteWidth*2;
		xRightBoundary = ApplicationController.Instance.bathroomAreaUpperLeftBoundary.transform.position.x-spriteWidth*2;
	}


	void FixedUpdate(){
		timeRemaining -= Time.deltaTime;
		if(timeRemaining < 0){
			timeRemaining = 0;
		}
		UpdateTimerText();
	}

	IEnumerator Spawn(){
		yield return new WaitForSeconds (2.0f);
		while(timeRemaining > 0){
			Vector3 spawnPos = new Vector3(Random.Range(xLeftBoundary,xRightBoundary), transform.position.y,0.0f);
			//used to represent rotation, "identitiy" essentially means no rotation
			Instantiate(drop, spawnPos, Quaternion.identity);
			yield return new WaitForSeconds(Random.Range(1.0f, 2.0f));
		}
	}

	void UpdateTimerText(){
		timerText.text = "Time Remaining:\n" + Mathf.RoundToInt(timeRemaining);
	}
}
