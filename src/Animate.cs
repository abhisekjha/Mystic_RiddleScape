using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Animate : MonoBehaviour
{
    [SerializeField] Image sprite; 
    public float scale;

    public  IEnumerator ScaleResolution () {
        sprite.transform.localScale *= scale;
        yield return new WaitForSeconds(0.10f); 
        sprite.transform.localScale *= (1/scale);
    }

    public void Animates(){
        StartCoroutine(ScaleResolution());
    }
}
