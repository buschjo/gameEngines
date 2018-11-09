using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coll_behaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//OnCollisionEnter2D --> sent when incoming collider makes contact with this object's collider
	//if drop collides with character, drop is destroyed
	void OnCollisionEnter2D (Collision2D collision){
		if(collision.gameObject.name == "drop"){
			Destroy(collision.gameObject);
		}
	}
}
