using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharBehaviour : MonoBehaviour {

	public float speed = 10.0f;

	void Start () {
	}
	
	// Update is called once per frame 
	void Update () {
		if(Input.GetKey(KeyCode.LeftArrow)){
			Vector3 position = this.transform.position;
			position.x -= speed * Time.deltaTime;
			this.transform.position = position;
		}
		
		if(Input.GetKey(KeyCode.RightArrow)){
			Vector3 position = this.transform.position;
			position.x += speed * Time.deltaTime;
			this.transform.position = position;
		}
	}
}
