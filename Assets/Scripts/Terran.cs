using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terran : Enemy
{
    public override void Update()
    {
        //base.Update(); lets this class use the Update of it's parent, in this case Enemy's Update so this guy can shoot.
        base.Update();
        transform.position += transform.up * Time.deltaTime;
    }
}