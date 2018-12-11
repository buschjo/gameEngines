using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour {

    [SerializeField]
    private Button playButton;

    public void StartGame()
    {
        SceneManager.LoadScene("periodstories");
    }

	public void ChooseFemale()
    {
        Statics.SetCharacter("female");
        Debug.Log("Choose: " + Statics.GetCharacter());
        playButton.interactable = true;
    }

    public void ChooseMale()
    {
        Statics.SetCharacter("male");
        Debug.Log("Choose: " + Statics.GetCharacter());
        playButton.interactable = true;
    }

    public void ChooseNB()
    {
        Statics.SetCharacter("non-binary");
        Debug.Log("Choose: " + Statics.GetCharacter());
        playButton.interactable = true;
    }
}
