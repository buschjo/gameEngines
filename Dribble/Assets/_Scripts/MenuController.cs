using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour {

    [SerializeField]
    private Button playButton;
    GameObject femaleDesc;
    GameObject maleDesc;
    GameObject nbDesc;
    public GameObject maleButtonIcon;
	public GameObject femaleButtonIcon;
	public GameObject nbButtonIcon;

    public void Start()
    {
        femaleDesc = GameObject.FindGameObjectWithTag("femaleBathroom");
        maleDesc = GameObject.FindGameObjectWithTag("maleBathroom");
        nbDesc = GameObject.FindGameObjectWithTag("nbBathroom");
        femaleDesc.SetActive(false);
        maleDesc.SetActive(false);
        nbDesc.SetActive(false);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("periodstories");
    }

	public void ChooseFemale()
    {
        Statics.SetCharacter("female");
        femaleDesc.SetActive(true);
        maleButtonIcon.SetActive(false);
        nbButtonIcon.SetActive(false);
        playButton.interactable = true;
    }

    public void ChooseMale()
    {
        Statics.SetCharacter("male");
        maleDesc.SetActive(true);
        femaleButtonIcon.SetActive(false);
        nbButtonIcon.SetActive(false);
        playButton.interactable = true;
    }

    public void ChooseNB()
    {
        Statics.SetCharacter("non-binary");
        nbDesc.SetActive(true);
        femaleButtonIcon.SetActive(false);
        maleButtonIcon.SetActive(false);
        playButton.interactable = true;
    }

}
