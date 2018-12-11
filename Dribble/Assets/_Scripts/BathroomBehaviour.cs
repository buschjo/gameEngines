using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BathroomBehaviour : MonoBehaviour
{
    string character;

    // Use this for initialization
    void Start()
    {
        character = ApplicationController.Instance.character;
    }

    void OnMouseDown()
    {
        if(character == "female"){
            if (tag == "femaleBathroom" || tag == "nbBathroom") ApplicationController.Instance.EmptyCup();
            else{GameOver();}
        }
        else if(character =="male"){
            if (tag == "maleBathroom" || tag == "nbBathroom") ApplicationController.Instance.EmptyCup();
            else{GameOver();}
        }
        else if(character =="non-binary"){
            if (tag == "nbBathroom") ApplicationController.Instance.EmptyCup();
            else{GameOver();}    
        }
        DestroyObject();
    }

    void GameOver(){
        ApplicationController.Instance.isRunning = false;
    }

    void DestroyObject()
    {
        Destroy(gameObject);
    }
}
