using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonActivation : MonoBehaviour
{   


    public bool upButton;
    public bool downButton;
    public bool leftButton;
    public bool rightButton;

    public Button buttonUp;
    public Button buttonDown;
    public Button buttonLeft;
    public Button buttonRight;

    public void setButtons(){
        buttonUp.gameObject.SetActive(upButton);
        buttonDown.gameObject.SetActive(downButton);
        buttonLeft.gameObject.SetActive(leftButton);
        buttonRight.gameObject.SetActive(rightButton);
    }


    void OnEnable(){
        setButtons();
    }
}
