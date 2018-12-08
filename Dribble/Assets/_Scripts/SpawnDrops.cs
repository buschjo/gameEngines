using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnDrops : MonoBehaviour {
	ApplicationController controller;
	public GameObject drop;
	private float xLeftBoundary;

	void Start () {
		controller = ApplicationController.Instance;
		setBoundaries();
		StartCoroutine(Spawn());
	}

	void setBoundaries(){
		float spriteWidth = drop.GetComponent<Renderer>().bounds.extents.x;
		xLeftBoundary = controller.lowerLeftBoundary.transform.position.x+spriteWidth*2;
	}

	IEnumerator Spawn(){
		yield return new WaitForSeconds (2.0f);
		while(controller.isRunning){
			Vector3 spawnPos = new Vector3(Random.Range(xLeftBoundary,transform.position.x), transform.position.y,0.0f);
			Instantiate(drop, spawnPos, Quaternion.identity);
			yield return new WaitForSeconds(Random.Range(1.0f, 2.0f));
		}
	}
}
