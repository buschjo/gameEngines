using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{

    [SerializeField]
    private Button playButton;
    GameObject femaleDesc;
    GameObject maleDesc;
    GameObject nbDesc;
    public GameObject backButton;
    public GameObject maleButton;
    public GameObject femaleButton;
    public GameObject nbButton;

    public void Start()
    {
        femaleDesc = GameObject.FindGameObjectWithTag("femaleBathroom");
        maleDesc = GameObject.FindGameObjectWithTag("maleBathroom");
        nbDesc = GameObject.FindGameObjectWithTag("nbBathroom");
        deactivateDescriptions();
        backButton.SetActive(false);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("periodstories");
    }

    public void ChooseFemale()
    {
        Statics.SetCharacter("female");
        AdjustCharSelectionWindow();
        playButton.interactable = true;
    }

    public void ChooseMale()
    {
        Statics.SetCharacter("male");
        AdjustCharSelectionWindow();
        playButton.interactable = true;
    }

    public void ChooseNB()
    {
        Statics.SetCharacter("non-binary");
        AdjustCharSelectionWindow();
        playButton.interactable = true;
    }

    public void AdjustCharSelectionWindow()
    {
        string character = Statics.GetCharacter();
        if (character == "female")
        {
            femaleDesc.SetActive(true);
            maleButton.SetActive(false);
            nbButton.SetActive(false);
        }
        if (character == "male")
        {
            maleDesc.SetActive(true);
            femaleButton.SetActive(false);
            nbButton.SetActive(false);
        }
        if (character == "non-binary")
        {
            nbDesc.SetActive(true);
            femaleButton.SetActive(false);
            maleButton.SetActive(false);
        }
        backButton.SetActive(true);
    }

    public void ReturnToCharSelectionWindow()
    {
        deactivateDescriptions();
        activateIcons();
        playButton.interactable = false;
    }

    void deactivateDescriptions()
    {
        femaleDesc.SetActive(false);
        maleDesc.SetActive(false);
        nbDesc.SetActive(false);
        backButton.SetActive(false);
    }

    void activateIcons()
    {
        nbButton.SetActive(true);
        femaleButton.SetActive(true);
        maleButton.SetActive(true);
    }
}
