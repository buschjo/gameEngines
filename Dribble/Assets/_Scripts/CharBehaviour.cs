using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharBehaviour : MonoBehaviour {

	[SerializeField]
	public float speed = 10.0f;

	void Start () {
	}
	
	// Update is called once per frame 
	void Update () {
		if(Input.GetKey(KeyCode.LeftArrow)){
			if(transform.position.x <= 0){
				//do nothing
			}else{
				transform.position -= new Vector3(speed * Time.deltaTime,0,0);
			}
		}
		if(Input.GetKey(KeyCode.RightArrow)){
			transform.position += new Vector3(speed * Time.deltaTime,0,0);
		}
	}
}
