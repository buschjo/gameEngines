using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnDrops : MonoBehaviour {
	public Camera cam; 
	public GameObject drop;
	public Text timerText;
	private float dropAreaWidth;
	public float timeRemaining;

	void Start () {
		if(cam == null){
			cam = Camera.main;
		}
		Vector3 upperCorner = new Vector3(Screen.width, Screen.height, 0.0f);
		Vector3 targetWidth = cam.ScreenToWorldPoint(upperCorner);
		float dropWidth = drop.GetComponent<Renderer>().bounds.extents.x;
		dropAreaWidth = targetWidth.x - dropWidth;
		StartCoroutine(Spawn());
		UpdateTimerText();
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
			Vector3 spawnPos = new Vector3(Random.Range(-dropAreaWidth,dropAreaWidth/2), transform.position.y,0.0f);
			//used to represent rotation, "identitiy" essentially means no rotation
			Instantiate(drop, spawnPos, Quaternion.identity);
			yield return new WaitForSeconds(Random.Range(1.0f, 2.0f));
		}
	}

	void UpdateTimerText(){
		timerText.text = "Time Remaining:\n" + Mathf.RoundToInt(timeRemaining);
	}
}
