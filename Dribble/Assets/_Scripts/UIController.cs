using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour {

	GameObject[] pauseObjects;
	GameObject[] gameOverObjects;
	ApplicationController controller;

	void Start () {
		ApplicationController.Instance.isRunning = true;
		//if timescale is 0, game is paused
		Time.timeScale = 1;
		pauseObjects = GameObject.FindGameObjectsWithTag("pause");
		gameOverObjects = GameObject.FindGameObjectsWithTag("gameover");
		hidePausedObjects();
		hideGameOver();
	}
	
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)){
			pauseElements();
			}
		if (ApplicationController.Instance.isRunning == false){
			showGameOver();
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
		if(Time.timeScale == 1 && ApplicationController.Instance.isRunning == true) {
				Time.timeScale = 0;
				showPausedObjects();
			} else if (Time.timeScale == 0 && ApplicationController.Instance.isRunning == true){
				Time.timeScale = 1;
				hidePausedObjects();
			}
	}

	void hideGameOver(){
		foreach(GameObject go in gameOverObjects){
			go.SetActive(false);
		}
	}

	void showGameOver(){
		foreach(GameObject go in gameOverObjects){
			go.SetActive(true);
		}
	}

	public void loadScene(string scene){
		SceneManager.LoadScene(scene);
	}
}
