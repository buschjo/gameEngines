﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharBehaviour : MonoBehaviour {

	[SerializeField]
	public float speed = 10.0f;
	public GameObject cup;

	void Start () {
	}
	
	// Update is called once per frame 
	void Update () {
		if(Input.GetKey(KeyCode.LeftArrow) && transform.position.x >= -ApplicationController.Instance.gameAreaWidth){
			transform.position -= new Vector3(speed * Time.deltaTime,0,0);
		}
		if(Input.GetKey(KeyCode.RightArrow) && transform.position.x <= ApplicationController.Instance.gameAreaWidth-ApplicationController.Instance.bathroomAreaWidth){
			transform.position += new Vector3(speed * Time.deltaTime,0,0);
		}
	}

}
