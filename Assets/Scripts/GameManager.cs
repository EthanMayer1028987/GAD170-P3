using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // POP UP variables

    public GameObject PopUpWindow;
    public GameObject Player;

    public string popUpTitle;
    public string popUpBody;
    public string popUpButton;

    public TextMeshProUGUI popUpTitleDisplay;
    public TextMeshProUGUI popUpBodyDisplay;
    public TextMeshProUGUI popUpButtonDisplay;



    // Start is called before the first frame update
    void Start()
    {
        PopUpWindow.SetActive(false);
        popUpTitle = "Getting Started";
        popUpBody = "Make your way to the table to be on display.";
    }

    // Update is called once per frame
    void Update()
    {
        popUpTitleDisplay.text = popUpTitle;
        popUpBodyDisplay.text = popUpBody;
        popUpButtonDisplay.text = popUpButton;

        // Pop Up Test

        if (Input.GetKeyDown("1"))
        {
            ChangePopUpTitle("Smash Mouth: All-Star");
            ChangePopUpBody("Somebody once told me the world is gonna roll me\nI ain't the sharpest tool in the shed.");
            ChangePopUpButton("OKAY");
            ServePopup();
        }

        if (Input.GetKeyDown("2"))
        {
            ChangePopUpTitle("Smash Mouth: All-Star (Continued)");
            ChangePopUpBody("She was looking kind of dumb with her finger and her thumb\nIn the shape of an 'L' on her forehead.");
            ChangePopUpButton("WELL");
            ServePopup();
        }

    }

    // POP UP FUNCTIONS

    public void ServePopup()
    {
        PopUpWindow.SetActive(true);
        Player.gameObject.GetComponent<PlayerMovement>().AllowMovement(false);
    }

    public void ClosePopup()
    {
        PopUpWindow.SetActive(false);
        Player.gameObject.GetComponent<PlayerMovement>().AllowMovement(true);
    }

    public void ChangePopUpTitle(string puTitleText)
    {
        popUpTitle = puTitleText;
    }


    public void ChangePopUpBody(string puBodyText)
    {
        popUpBody = puBodyText;
    }
    public void ChangePopUpButton(string puButtonText)
    {
        popUpButton = puButtonText;
    }
}
