// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class InventoryDisplay : MonoBehaviour
// {
//     public Inventory inventory;
//     public Item[] slots;
//     private void Start()
//     {
//         UpdateInventory();
//     }
//     void UpdateInventory()
//     {
//         for (int i = 0; i < slots.Length; i++)
//         {
//             if (i < inventory.items.Count)
//             {
//                 slots[i].model.SetActive(true);
//                 slots[i].UpdateItemDisplay(inventory.items[i].itemType.icon, i);
//             }
//             else 
//             {
//                 slots[i].model.SetActive(false);
//             }
//         }
//     }
// }
