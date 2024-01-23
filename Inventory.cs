using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[CreateAssetMenu]
public class Inventory : MonoBehaviour
{
    public int maxItems;
    public List<Item> items = new();
    public bool AddItem(Item itemToAdd)
    {
        // Finds an empty slot if there is one
        for (int i = 0; i < items.Count; i++)
        {
            if (items[i] == null)
            {
                items[i] = itemToAdd;
                return true;
            }
        }
        // Adds a new item if the inventory has space
        if (items.Count < maxItems)
        {
            items.Add(itemToAdd);
            return true;
        }
        Debug.Log("No space in the inventory");
        return false;
    }
}
// public class Inventory : MonoBehaviour{
//     private const int SLOTS = 14;

//     private List<IInventoryItem> mItems = new List<IInventoryItem> < IInventoryItem>();
//     public event EventHandler<InventoryEventArgs> ItemAdded;
//     public void AddItem(IInventoryItem item){
//         if(mItems.Count < SLOTS){
//             item.OnPickup();
//         }

//         if(ItemAdded != null){
//             ItemAdded(this, new InventoryEventArgs(item));
//         }
//     }
// }

// // public class Inventory : ScriptableObject
// // {   
// //     public int maxItems = 14;
// //     public List<Item> items = new();
// //     public bool AddItem(Item itemToAdd)
// //     {
// //         for (int i = 0; i < items.Count; i++)
// //         {
// //             if (items[i] == null)
// //             {
// //                 items[i] = itemToAdd;
// //                 return true;
// //             }
// //         }

// //         if (items.Count < maxItems)
// //         {
// //             items.Add(itemToAdd);
// //             return true;
// //         }

// //         return false;
// //     }
// //     public void RemoveItem(Item itemToRemove)
// //     {
// //         items.Remove(itemToRemove);
// //     }
// // }

