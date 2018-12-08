using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBathrooms : MonoBehaviour {
	ApplicationController controller;
	public GameObject maleBathroomIcon;
	public GameObject femaleBathroomIcon;
	public GameObject nbBathroomIcon;
    private float xLeftBoundary;
    private float xRightBoundary;
    private float yUpperBoundary;
    private float yLowerBoundary;

    void Start () {
		controller = ApplicationController.Instance;
		setBoundaries();
		StartCoroutine(Spawn());
	}

	void setBoundaries(){
		float spriteWidth = maleBathroomIcon.GetComponent<Renderer>().bounds.extents.x;
		float spriteHeight = maleBathroomIcon.GetComponent<Renderer>().bounds.extents.y;
		xLeftBoundary = controller.bathroomAreaUpperLeftBoundary.transform.position.x+spriteWidth;
		xRightBoundary = controller.upperRightBoundary.transform.position.x-spriteWidth;
		yUpperBoundary = controller.bathroomAreaUpperLeftBoundary.transform.position.y-spriteHeight;
		yLowerBoundary = controller.lowerLeftBoundary.transform.position.y+spriteHeight;
	}

	IEnumerator Spawn(){
		yield return new WaitForSeconds (2.0f);
		while(controller.isRunning){
			instantiateBathroom(new Vector3(Random.Range(xLeftBoundary, xRightBoundary), Random.Range(yLowerBoundary, yUpperBoundary),0.0f));			
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
