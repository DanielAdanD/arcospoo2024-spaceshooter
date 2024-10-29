using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wingman : Enemy
{
    public override void Update()
    {
        base.Update();
        transform.position -= transform.up * Time.deltaTime;
    }
}
