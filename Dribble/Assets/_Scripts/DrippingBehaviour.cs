using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrippingBehaviour : MonoBehaviour {
	Animator animator;

	void Start(){
		animator = GetComponent<Animator>();
	}

	void OnTriggerEnter2D(Collider2D collision){
		if(collision.gameObject.tag == "cup"){
			ApplicationController.Instance.IncreaseScore();
			DestroyObject();	
		}else{
			Destroy(GetComponent<Rigidbody2D>());
			animator.SetTrigger("scatter");
		}
		
	}

	void DestroyObject(){
		Destroy(gameObject);
	}
}
