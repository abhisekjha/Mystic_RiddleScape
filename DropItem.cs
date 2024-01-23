// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public void DropItem(int itemIndex) : MonoBehaviour
// {
//     // Creates a new object and gives it the item data
//     GameObject droppedItem = new GameObject();
//     droppedItem.AddComponent<Rigidbody>();
//     droppedItem.AddComponent<InstanceItemContainer>().item = inventory.items[itemIndex];
//     GameObject itemModel = Instantiate(inventory.items[itemIndex].itemType.model, droppedItem.transform);
//     // Removes the item from the inventory
//     inventory.items.RemoveAt(itemIndex);
//     // Updates the inventory again
//     UpdateInventory();
// }
