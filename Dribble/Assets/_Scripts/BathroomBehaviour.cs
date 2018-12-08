using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BathroomBehaviour : MonoBehaviour
{

    GameObject maleIcon;
    GameObject femaleIcon;
    GameObject nbIcon;
    string character = ApplicationController.Instance.character;

    // Use this for initialization
    void Start()
    {
        maleIcon = GameObject.FindGameObjectWithTag("maleBathroom");
        femaleIcon = GameObject.FindGameObjectWithTag("femaleBathroom");
        nbIcon = GameObject.FindGameObjectWithTag("nbBathroom");
    }

    void OnMouseDown()
    {
        if (character == "female")
        {
            if (femaleIcon || nbIcon) ApplicationController.Instance.EmptyCup();
            else
            {
                print("gameOvaries (female)");
                ApplicationController.Instance.isRunning = false;
            }
        }
        else if (character == "male")
        {
            if (maleIcon || nbIcon) ApplicationController.Instance.EmptyCup();
            else
            {
                print("gameOvaries (male)");
                ApplicationController.Instance.isRunning = false;
            }
        }
        else if (character == "non-binary")
        {
            if (nbIcon) ApplicationController.Instance.EmptyCup();
            else
            {
                print("gameOvaries (nb)");
                ApplicationController.Instance.isRunning = false;
            }
        }
        DestroyObject();
    }

    void DestroyObject()
    {
        Destroy(gameObject);
    }
}
