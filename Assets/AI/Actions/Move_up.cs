using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using RAIN.Action;
using RAIN.Core;

[RAINAction]
public class Move_up : RAINAction
{
    // Movement Speed
    public float speed = 16;
    public override void Start(RAIN.Core.AI ai)
    {
        base.Start(ai);
    }

    public override ActionResult Execute(RAIN.Core.AI ai)
    {
        if (GameObject.Find("Player_green").transform.position.y > GameObject.Find("Player_orange").transform.position.y && ai.WorkingMemory.GetItem<string>("direccion") != "down")
        {
            GameObject.Find("Player_orange").transform.rotation = Quaternion.Euler(0, 0, 0);
            GameObject.Find("Player_orange").GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
            ai.WorkingMemory.SetItem<string>("direccion","up");
            return ActionResult.SUCCESS;
        }
        else
        {
            return ActionResult.FAILURE;
        }
        
    }

    public override void Stop(RAIN.Core.AI ai)
    {
        base.Stop(ai);
    }
}