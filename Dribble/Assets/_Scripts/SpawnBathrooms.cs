using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBathrooms : MonoBehaviour {

	public Camera cam; 
	public GameObject maleBathroomIcon;
	public GameObject femaleBathroomIcon;
	public GameObject nbBathroomIcon;
	private float dropAreaWidth;
	private float dropAreaHeight;
	public float timeRemaining;

	void Start () {
		if(cam == null){
			cam = Camera.main;
		}
		Vector3 upperCorner = new Vector3(Screen.width, Screen.height, 0.0f);
		Vector3 targetSize = cam.ScreenToWorldPoint(upperCorner);
		float iconWidth = maleBathroomIcon.GetComponent<Renderer>().bounds.extents.x;
		float iconHeight = maleBathroomIcon.GetComponent<Renderer>().bounds.extents.y;
		dropAreaWidth = targetSize.x - iconWidth;
		dropAreaHeight = targetSize.y - iconHeight;

		StartCoroutine(Spawn());
	}

	IEnumerator Spawn(){
		yield return new WaitForSeconds (2.0f);
		while(timeRemaining > 0){
			instantiateBathroom(new Vector3(Random.Range(ApplicationController.Instance.gameAreaWidth-ApplicationController.Instance.bathroomAreaWidth, ApplicationController.Instance.gameAreaWidth), Random.Range(transform.position.y, -dropAreaHeight),0.0f));			
			yield return new WaitForSeconds(Random.Range(1.0f, 2.0f));
		}
	}

	void instantiateBathroom(Vector3 spawnPos){
			int index = Random.Range(0,3);
			if(index == 0){
				Instantiate(nbBathroomIcon, spawnPos, Quaternion.identity);
			}
			if(index == 1){
				Instantiate(maleBathroomIcon, spawnPos, Quaternion.identity);
			}
			if(index == 2){
				Instantiate(femaleBathroomIcon, spawnPos, Quaternion.identity);
			}
	}

}
