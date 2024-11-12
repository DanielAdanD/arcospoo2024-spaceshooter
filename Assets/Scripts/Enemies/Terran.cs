using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terran : Enemy
{
    float speed = 0.5f;    

    
    public override void Update()
    {
        //base.Update(); lets this class use the Update of it's parent, in this case Enemy's Update so this guy can shoot.
        base.Update();
        transform.position -= transform.up * speed * Time.deltaTime;
    }
}