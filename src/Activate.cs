using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate : MonoBehaviour
{
    void OnMouseDown (){
        GetComponent<AudioSource> ().Play ();
    }
}
