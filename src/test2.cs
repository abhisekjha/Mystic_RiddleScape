using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test2 : MonoBehaviour
{

    public Image[] inventorySlots;
    public Image puzzlePieceImage;
    public Button puzzlePiece;
    public void onClick(){
        
        for(int i = 0; i < inventorySlots.Length; i++){
            if(inventorySlots[i].sprite == null){
                inventorySlots[i].sprite = puzzlePieceImage.sprite;
                var tempColor = inventorySlots[i].color;
                tempColor.a = 1f;
                inventorySlots[i].color = tempColor;
                puzzlePiece.gameObject.SetActive(false);
                break;
            }
        }
    }
}
