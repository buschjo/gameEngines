using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharBehaviour : MonoBehaviour {

	[SerializeField]
	public float speed = 10.0f;
	[SerializeField]
	private int maxCapacity = 10;
	Animator animator;
    private float xLeftBoundary;
    private float xRightBoundary;

    void Start () {
		animator = GetComponent<Animator>();
		setBoundaries();
	}
	void setBoundaries(){
		float spriteWidth = GetComponent<SpriteRenderer>().bounds.size.x/2;
		xLeftBoundary = ApplicationController.Instance.lowerLeftBoundary.transform.position.x+spriteWidth;
		xRightBoundary = ApplicationController.Instance.bathroomAreaUpperLeftBoundary.transform.position.x-spriteWidth;
	}
	
	// Update is called once per frame 
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
		if(ApplicationController.Instance.score <= maxCapacity){
			if(ApplicationController.Instance.score == maxCapacity){
				animator.SetTrigger("toTheBrimFull");
			}
			if(ApplicationController.Instance.score > maxCapacity/2){
				animator.SetTrigger("almostFull");
			}
			if(ApplicationController.Instance.score > maxCapacity/4){
				animator.SetTrigger("halfFull");
			}
			if(ApplicationController.Instance.score > 0){
				animator.SetTrigger("firstBlood");
			}
			if(ApplicationController.Instance.score == 0){
				animator.SetTrigger("emptyCup");
			}
		}else{
			animator.SetTrigger("spill");
			//Game Ovaries
		}
	}

}
