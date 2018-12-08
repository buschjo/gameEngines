using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharBehaviour : MonoBehaviour {

	[SerializeField]
	public float speed = 10.0f;
	[SerializeField]
	private int maxCapacity = 10;
	Animator animator;
	ApplicationController controller;
    private float xLeftBoundary;
    private float xRightBoundary;

    void Start () {
		animator = GetComponent<Animator>();
		controller = ApplicationController.Instance;
		setBoundaries();
	}
	void setBoundaries(){
		float spriteWidth = GetComponent<SpriteRenderer>().bounds.size.x/2;
		xLeftBoundary = controller.lowerLeftBoundary.transform.position.x+spriteWidth;
		xRightBoundary = controller.bathroomAreaUpperLeftBoundary.transform.position.x-spriteWidth;
	}
	
	void Update () {
		Move();
		SetCupState();
	}
	void Move(){
		if(Input.GetKey(KeyCode.LeftArrow) && transform.position.x >= xLeftBoundary){
			transform.position -= new Vector3(speed * Time.deltaTime,0,0);
		}
		if(Input.GetKey(KeyCode.RightArrow) && transform.position.x <= xRightBoundary){
			transform.position += new Vector3(speed * Time.deltaTime,0,0);
		}
	}
	void SetCupState(){
		if(controller.score <= maxCapacity){
			if(controller.score == maxCapacity){
				animator.SetTrigger("toTheBrimFull");
			}
			if(controller.score > maxCapacity/2){
				animator.SetTrigger("almostFull");
			}
			if(controller.score > maxCapacity/4){
				animator.SetTrigger("halfFull");
			}
			if(controller.score > 0){
				animator.SetTrigger("firstBlood");
			}
			if(controller.score == 0){
				animator.SetTrigger("emptyCup");
			}
		}else{
			animator.SetTrigger("spill");
			controller.isRunning = false;
		}
	}

}
