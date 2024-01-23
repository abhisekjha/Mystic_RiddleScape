using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseManager : MonoBehaviour
{   
    public AudioSource audioSource;
    // Start is called before the first frame update
  

    public void Pause(){
        Time.timeScale = 0;
        audioSource.Pause();
    }
    
    public void Resume(){
        Time.timeScale = 1;
        audioSource.UnPause();
    }
}
