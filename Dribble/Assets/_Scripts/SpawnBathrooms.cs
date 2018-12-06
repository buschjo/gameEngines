using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBathrooms : MonoBehaviour {
	public GameObject maleBathroomIcon;
	public GameObject femaleBathroomIcon;
	public GameObject nbBathroomIcon;
	public float timeRemaining;
    private float xLeftBoundary;
    private float xRightBoundary;
    private float yUpperBoundary;
    private float yLowerBoundary;

    void Start () {
		setBoundaries();
		StartCoroutine(Spawn());
	}

	void setBoundaries(){
		float iconWidth = maleBathroomIcon.GetComponent<Renderer>().bounds.extents.x;
		float iconHeight = maleBathroomIcon.GetComponent<Renderer>().bounds.extents.y;
		xLeftBoundary = ApplicationController.Instance.bathroomAreaUpperLeftBoundary.transform.position.x+iconWidth;
		xRightBoundary = ApplicationController.Instance.upperRightBoundary.transform.position.x-iconWidth;
		yUpperBoundary = ApplicationController.Instance.bathroomAreaUpperLeftBoundary.transform.position.y-iconHeight;
		yLowerBoundary = ApplicationController.Instance.lowerLeftBoundary.transform.position.y+iconHeight;
	}

	IEnumerator Spawn(){
		yield return new WaitForSeconds (2.0f);
		while(timeRemaining > 0){
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
