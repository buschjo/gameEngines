using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharBehaviour : MonoBehaviour {

    private bool isMovingRight;
    private bool isMovingLeft;

    // Use this for initialization
    void Start () {
        isMovingRight = false;
        isMovingLeft = false;
	}
	
	// Update is called once per frame 
	void Update () {
        if(isMovingLeft || isMovingRight){
            transform.position += move();      
        }else{
            isMovingLeft = Input.GetKeyDown(KeyCode.LeftArrow);
            isMovingRight = Input.GetKeyDown(KeyCode.RightArrow);
        }
	}
    private Vector3 move(){
        float step = 0;
        if(isMovingLeft){
            isMovingLeft = isKeyReleased(KeyCode.LeftArrow);
            step = -10.0f;
        }
        if(isMovingRight){
            isMovingRight = isKeyReleased(KeyCode.RightArrow);
            step = 10.0f;
        }
        return new Vector3(step * Time.deltaTime, 0,0);
    }

    private bool isKeyReleased(KeyCode keyCode){
        return !Input.GetKeyUp(keyCode);
    }
}
