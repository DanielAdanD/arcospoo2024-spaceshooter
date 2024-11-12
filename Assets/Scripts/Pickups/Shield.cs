using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : Item
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Player player = other.gameObject.GetComponentInParent<Player>();
        if (player != null)
        {
            Debug.Log("Got an item");
        }
    }
}
