using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class char_behaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.LeftArrow)){
			Vector3 position = this.transform.position;
			position.x-=0.5f;
			this.transform.position = position;
		}
		
		if(Input.GetKeyDown(KeyCode.RightArrow)){
			Vector3 position = this.transform.position;
			position.x+=0.5f;
			this.transform.position = position;
		}
	}
}
