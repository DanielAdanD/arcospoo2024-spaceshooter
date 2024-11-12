using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
     float speed = 1;

    public virtual void Update()
    {
        transform.position -= transform.up *speed * Time.deltaTime;
    }
}
