using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour {

	GameObject[] pauseObjects;
	public bool alive;

	void Start () {
		//alive = false in SpawnDrops --> Collider Check
		alive = true;
		//if timescale is 0, game is paused
		Time.timeScale = 1;
		pauseObjects = GameObject.FindGameObjectsWithTag("pause");
		hidePausedObjects();
	}
	
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)){
			pauseElements();
			}
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
	
	public void pauseController(){
		pauseElements();
	} 

	void pauseElements(){
		if(Time.timeScale == 1) {
				Time.timeScale = 0;
				showPausedObjects();
			} else if (Time.timeScale == 0){
				Time.timeScale = 1;
				hidePausedObjects();
			}
	}

	public void loadScene(string scene){
		SceneManager.LoadScene(scene);
	}
}
