using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collect_drops : MonoBehaviour {
	public Camera cam;
	//drop is prefab, template for a game object
	public GameObject drop;
	private float maxWidth;

	void Start () {
		if(cam == null){
			cam = Camera.main;
		}
		//translate screen space > ScreenToWorldPoint: transforms pos from screen space to world space
		Vector3 upperCorner = new Vector3(Screen.width, Screen.height, 0.0f);
		Vector3 targetWidth = cam.ScreenToWorldPoint(upperCorner);
		float dropWidth = drop.GetComponent<Renderer>().bounds.extents.x;
		maxWidth = targetWidth.x - dropWidth;
		StartCoroutine(Spawn());
	}

	//instatiate drops at random spawn position
	//this is a coroutine that has to be called manually
	IEnumerator Spawn(){
		yield return new WaitForSeconds (2.0f);
		while(true){
			Vector3 spawnPosition = new Vector3(
				Random.Range(-maxWidth,maxWidth), 
				transform.position.y,
				0.0f
				);
			//this essentially means no rotation
			Quaternion spawnRotation = Quaternion.identity;
			Instantiate(drop, spawnPosition, spawnRotation);
			//so we don't freeze programme with infinite loop, wait between 1 and 2 seconds before starting loop again
			yield return new WaitForSeconds(Random.Range(1.0f, 2.0f));
		}
	}
}
