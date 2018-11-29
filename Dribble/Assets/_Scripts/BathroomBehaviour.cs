using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BathroomBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}

	void OnMouseDown ()
    {
		Debug.Log("Empty the Cup");
        ApplicationController.Instance.EmptyCup();
    }
}
