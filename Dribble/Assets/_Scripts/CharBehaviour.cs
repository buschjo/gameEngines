using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharBehaviour : MonoBehaviour {

	[SerializeField]
	public float speed = 10.0f;
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
		if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A) && transform.position.x >= xLeftBoundary){
			transform.position -= new Vector3(speed * Time.deltaTime,0,0);
		}
		if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D) && transform.position.x <= xRightBoundary){
			transform.position += new Vector3(speed * Time.deltaTime,0,0);
		}
	}
	void SetCupState(){
		if(controller.cupFillAmount <= controller.maxCapacity){
			if(controller.cupFillAmount == controller.maxCapacity){
				animator.SetTrigger("toTheBrimFull");
			} 
			if(controller.cupFillAmount > controller.maxCapacity/2){
				animator.SetTrigger("almostFull");
			}
			if(controller.cupFillAmount > controller.maxCapacity/4){
				animator.SetTrigger("halfFull");
			}
			if(controller.cupFillAmount > 0){
				animator.SetTrigger("firstBlood");
			}
			if(controller.cupFillAmount == 0){
				animator.SetTrigger("emptyCup");
			}
		}else{
			animator.SetTrigger("spill");
			controller.isRunning = false;
		}
	}

}
