using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using RAIN.Action;
using RAIN.Core;

[RAINAction]
public class Comprobar_muros : RAINAction
{
    //////izquierda y arriba
    private Vector2 origen_up_left;
    private Vector2 origen_down_left;
    private Vector2 origen_right_up;
    private Vector2 origen_left_up;
    //////derecha y abajo
    private Vector2 origen_up_right;
    private Vector2 origen_down_right;
    private Vector2 origen_right_down;
    private Vector2 origen_left_down;
    private float distancia;
    public override void Start(RAIN.Core.AI ai)
    {
        distancia = (float)0.9;
        //////izquierda y arriba
        origen_up_left = new Vector2(GameObject.Find("Player_orange").transform.position.x - (float)0.4, GameObject.Find("Player_orange").transform.position.y + (float)0.6);
        origen_down_left = new Vector2(GameObject.Find("Player_orange").transform.position.x - (float)0.4, GameObject.Find("Player_orange").transform.position.y - (float)0.6);
        origen_right_up = new Vector2(GameObject.Find("Player_orange").transform.position.x + (float)0.6, GameObject.Find("Player_orange").transform.position.y + (float)0.4);
        origen_left_up = new Vector2(GameObject.Find("Player_orange").transform.position.x - (float)0.6, GameObject.Find("Player_orange").transform.position.y + (float)0.4);
        //////derecha y abajo
        origen_up_right = new Vector2(GameObject.Find("Player_orange").transform.position.x + (float)0.4, GameObject.Find("Player_orange").transform.position.y + (float)0.6);
        origen_down_right = new Vector2(GameObject.Find("Player_orange").transform.position.x + (float)0.4, GameObject.Find("Player_orange").transform.position.y - (float)0.6);
        origen_right_down = new Vector2(GameObject.Find("Player_orange").transform.position.x + (float)0.6, GameObject.Find("Player_orange").transform.position.y - (float)0.4);
        origen_left_down = new Vector2(GameObject.Find("Player_orange").transform.position.x - (float)0.6, GameObject.Find("Player_orange").transform.position.y - (float)0.4);
        base.Start(ai);
    }

    public override ActionResult Execute(RAIN.Core.AI ai)
    {
        if ((Physics2D.Raycast(origen_up_left, new Vector2(0, distancia), distancia) || 
            Physics2D.Raycast(origen_up_right, new Vector2(0, distancia), distancia)) && 
            ai.WorkingMemory.GetItem<string>("direccion") != "down")
        {
            return ActionResult.SUCCESS;
        }
        else if ((Physics2D.Raycast(origen_down_left, new Vector2(0, -distancia), distancia) || 
                Physics2D.Raycast(origen_down_right, new Vector2(0, -distancia), distancia)) && 
                ai.WorkingMemory.GetItem<string>("direccion") != "up")
        {
            return ActionResult.SUCCESS;
        }
        else if ((Physics2D.Raycast(origen_right_up, new Vector2(distancia, 0), distancia) || 
                Physics2D.Raycast(origen_right_down, new Vector2(distancia, 0), distancia)) && 
                ai.WorkingMemory.GetItem<string>("direccion") != "left")
        {
            return ActionResult.SUCCESS;
        }
        else if ((Physics2D.Raycast(origen_left_up, new Vector2(-distancia, 0), distancia) || 
                Physics2D.Raycast(origen_left_down, new Vector2(-distancia, 0), distancia)) && 
                ai.WorkingMemory.GetItem<string>("direccion") != "right")
        {
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