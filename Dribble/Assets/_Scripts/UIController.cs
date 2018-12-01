using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour {

	GameObject[] pauseObjects;

	void Start () {
		//if timescale is 0, game is paused
		Time.timeScale = 1;
		pauseObjects = GameObject.FindGameObjectsWithTag("pause");
		hidePausedObjects();
	}

	void hidePausedObjects(){
		foreach(GameObject go in pauseObjects){
			go.SetActive(false);
		}
	}

	void showPausedObjects(){
		foreach(GameObject go in pauseObjects){
			go.SetActive(true);
		}
	}
	
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)){
			pauseMethods();
			}
		}
	
	public void pauseController(){
		pauseMethods();
	} 

	void pauseMethods(){
		if(Time.timeScale == 1) {
				Time.timeScale = 0;
				showPausedObjects();
			} else if (Time.timeScale == 0){
				Time.timeScale = 1;
				hidePausedObjects();
			}
	}
}
