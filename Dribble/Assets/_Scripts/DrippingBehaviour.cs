using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrippingBehaviour : MonoBehaviour {
	Animator animator;
	ApplicationController controller;

	void Start(){
		animator = GetComponent<Animator>();
		controller = ApplicationController.Instance;
	}

	void OnTriggerEnter2D(Collider2D collision){
		if(collision.gameObject.tag == "cup"){
			ApplicationController.Instance.IncreaseScore();
			DestroyObject();	
		}else{
			Destroy(GetComponent<Rigidbody2D>());
			animator.SetTrigger("scatter");
			controller.isRunning = false;
		}
		
	}

	void DestroyObject(){
		Destroy(gameObject);
	}
}
