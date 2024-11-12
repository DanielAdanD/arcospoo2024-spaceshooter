using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wingman : Enemy
{
     float speed = 0.5f;


    public override void Update()
    {
        base.Update();
        transform.position -= transform.up * speed * Time.deltaTime;
    }
}
