using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using RAIN.Action;
using RAIN.Core;

[RAINAction]
public class Move_left : RAINAction
{
    // Movement Speed
    public float speed = 16;
    public override void Start(RAIN.Core.AI ai)
    {
        base.Start(ai);
    }

    public override ActionResult Execute(RAIN.Core.AI ai)
    {
        if (GameObject.Find("Player_green").transform.position.x < GameObject.Find("Player_orange").transform.position.x && ai.WorkingMemory.GetItem<string>("direccion") != "right")
        {
            GameObject.Find("Player_orange").transform.rotation = Quaternion.Euler(0, 0, 90);
            GameObject.Find("Player_orange").GetComponent<Rigidbody2D>().velocity = -Vector2.right * speed;
            ai.WorkingMemory.SetItem<string>("direccion", "left");
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