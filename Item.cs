using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu]
public class Item : ScriptableObject
{
    public int id;
    public string itemName;
    public Sprite icon;
    public string description;
}
