using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class BackgroundTraversal : MonoBehaviour
{
    public Button button;
    public GameObject FL;
    public GameObject FC;
    public GameObject FR;
    public GameObject ML;
    public GameObject MC;
    public GameObject MR;
    public GameObject MRClose;
    public GameObject BL;
    public GameObject BC;
    public GameObject BR;
    
    public GameObject FL2;
    public GameObject FC2;
    public GameObject FR2;
    public GameObject ML2;
    public GameObject MC2;
    public GameObject MR2;
    public GameObject MRClose2;
    public GameObject BL2;
    public GameObject BC2;
    public GameObject BR2;

    public void onClick(){
        traverseDown();
    }

    private void traverseDown(){
        if(BL.activeSelf == true){
            BL.gameObject.SetActive(false);
            BL2.gameObject.SetActive(true);
        }
        else if(BC.activeSelf == true){
            BC.gameObject.SetActive(false);
            BC2.gameObject.SetActive(true);
        }
        else if(BR.activeSelf == true){
            BR.gameObject.SetActive(false);
            BR2.gameObject.SetActive(true);
        }
        else if(ML.activeSelf == true){
            ML.gameObject.SetActive(false);
            ML2.gameObject.SetActive(true);
        }
        else if(MC.activeSelf == true){
            MC.gameObject.SetActive(false);
            MC2.gameObject.SetActive(true);
        }
        else if(MR.activeSelf == true){
            MR.gameObject.SetActive(false);
            MR2.gameObject.SetActive(true);
        }
        else if(MRClose.activeSelf == true){
            MRClose.gameObject.SetActive(false);
            MRClose2.gameObject.SetActive(true);
        }
        else if(FL.activeSelf == true){
            FL.gameObject.SetActive(false);
            FL2.gameObject.SetActive(true);
        }
        else if(FC.activeSelf == true){
            FC.gameObject.SetActive(false);
            FC2.gameObject.SetActive(true);
        }
        else if(FR.activeSelf == true){
            FR.gameObject.SetActive(false);
            FR2.gameObject.SetActive(true);
        }
        


    }

}
