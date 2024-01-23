using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class test : MonoBehaviour
{
    
    public bool upButton;
    public bool downButton;
    public bool leftButton;
    public bool rightButton;    
    
    public Button buttonUp;
    public Button buttonDown;
    public Button buttonLeft;
    public Button buttonRight;

    public GameObject topBackground;
    public GameObject bottomBackground;
    public GameObject leftBackground;
    public GameObject rightBackground;

    private int upCheck = 0;
    private int downCheck = 0;
    private int leftCheck = 0;
    private int rightCheck = 0;

    void Start(){
        setButtons();
        upCheck = 0;
        downCheck = 0;
        leftCheck = 0;
        rightCheck = 0;
        buttonUp.onClick.AddListener(UpTraversal);
        if (upCheck == 1) return;
        buttonDown.onClick.AddListener(DownTraversal);
        if (downCheck == 1) return;
        buttonLeft.onClick.AddListener(LeftTraversal);
        if (leftCheck == 1) return;
        buttonRight.onClick.AddListener(RightTraversal);
        if (rightCheck == 1) return;
        
    }

    public void setButtons(){
        buttonUp.gameObject.SetActive(upButton);
        buttonDown.gameObject.SetActive(downButton);
        buttonLeft.gameObject.SetActive(leftButton);
        buttonRight.gameObject.SetActive(rightButton);
    }

    public void resetButtons(){
        buttonUp.gameObject.SetActive(false);
        buttonDown.gameObject.SetActive(false);
        buttonLeft.gameObject.SetActive(false);
        buttonRight.gameObject.SetActive(false);
    }

    private void UpTraversal(){
        //if(topBackground != null){
            this.gameObject.SetActive(false);
            topBackground.gameObject.SetActive(true);
       // }
        upCheck = 1;
        
    }

    private void DownTraversal(){
       // if (bottomBackground != null){
            this.gameObject.SetActive(false);

            bottomBackground.gameObject.SetActive(true);
       // }
        downCheck = 1;
        
    }

    private void LeftTraversal(){
        //if(leftBackground != null){
            this.gameObject.SetActive(false);
            resetButtons();
            leftBackground.gameObject.SetActive(true);
       // }
        leftCheck = 1;
    }

    private void RightTraversal(){
       // if(rightBackground != null){
            this.gameObject.SetActive(false);
            resetButtons();
            rightBackground.gameObject.SetActive(true);
       // }
        rightCheck = 1;
            
    }

    // public void OnClick(BaseEventData eventData)
    // {
    //     if(eventData.selectedObject == buttonUp)
    //     {
    //         this.gameObject.SetActive(false);
    //         topBackground.gameObject.SetActive(true);
    //     }
    //     if(eventData.selectedObject == buttonDown)
    //     {
    //         this.gameObject.SetActive(false);
    //         bottomBackground.gameObject.SetActive(true);
    //     }
    //     if(eventData.selectedObject == buttonLeft)
    //     {
    //         this.gameObject.SetActive(false);
    //         leftBackground.gameObject.SetActive(true);
    //     }
    //     if(eventData.selectedObject == buttonRight)
    //     {
    //         this.gameObject.SetActive(false);
    //         rightBackground.gameObject.SetActive(true);
    //     }
    // }
}

