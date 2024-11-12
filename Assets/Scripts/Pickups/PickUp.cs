using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PickUp : ScriptableObject
{
    public Sprite pickUpSprite;
    public  string pickUpName;
    public int dropChance;

    public PickUp(string pickUpName, int dropChance)
    {
        this.pickUpName = pickUpName;
        this.dropChance = dropChance;
    }
}
