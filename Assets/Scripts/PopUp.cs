using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUp : MonoBehaviour
{

    public string customPopUpTitle;
    public string customPopUpBody;
    public string customPopUpButton;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<GameManager>().ChangePopUpTitle(customPopUpTitle);
            other.gameObject.GetComponent<GameManager>().ChangePopUpBody(customPopUpBody);
            other.gameObject.GetComponent<GameManager>().ChangePopUpButton(customPopUpButton);
            other.gameObject.GetComponent<GameManager>().ServePopup();
        }
    }
}
