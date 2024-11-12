using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpBag : MonoBehaviour
{
    public GameObject droppedItemPrefab;
    public List<PickUp> pickupList = new List<PickUp>();

    PickUp GetDroppedItem()
    {
        int randomNumber = Random.Range(1, 101); //1 - 100
        List<PickUp> possibleItems = new List<PickUp>();
        foreach (PickUp item in pickupList)
        {
            if(randomNumber <= item.dropChance)
            {
                possibleItems.Add(item);
                
            }
        } 
        if (possibleItems.Count > 0)
        {
            PickUp droppedItem = possibleItems[Random.Range(0, possibleItems.Count)];
            return droppedItem;
        }
        Debug.Log("No pickup dropped");
        return null;
    }

    public void InstantiatePickup(Vector3 spawnPos)
    {
        PickUp droppedItem = GetDroppedItem();
        if (droppedItem != null)
        {
            GameObject pickUpGameObject = Instantiate(droppedItemPrefab, spawnPos, Quaternion.identity);
            pickUpGameObject.GetComponentInChildren<SpriteRenderer>().sprite = droppedItem.pickUpSprite;

            if (droppedItem.pickUpName == "Shield")
            {
                pickUpGameObject.AddComponent<Shield>();
            }
        }
        else
        {
            return;
        }
    }
}
