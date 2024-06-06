// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class InventoryDisplay : MonoBehaviour
// {
//     public Inventory inventory;
//     public ItemDisplay[] slots;
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
//                 slots[i].gameObject.SetActive(true);
//                 slots[i].UpdateItemDisplay(inventory.items[i].icon, i);
//             }
//             else 
//             {
//                 slots[i].gameObject.SetActive(false);
//             }
//         }
//     }

//     public void DropItem(int itemIndex)
// {
//     // Creates a new object and gives it the item data
//     GameObject droppedItem = new GameObject();
//     droppedItem.AddComponent<Rigidbody>();
//     droppedItem.AddComponent<InstanceItemContainer>().item = inventory.items[itemIndex];
//     inventory.items.RemoveAt(itemIndex);
//     // Updates the inventory again
//     UpdateInventory();
// }
// }
