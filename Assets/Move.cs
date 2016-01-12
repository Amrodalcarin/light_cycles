using UnityEngine;
using System.Collections.Generic;

public class Move : MonoBehaviour {
    //Trail
    private List<Vector2> puntos_trail;
    public GameObject col;

    // Movement keys (customizable in Inspector)
    public KeyCode upKey;
    public KeyCode downKey;
    public KeyCode rightKey;
    public KeyCode leftKey;
    private KeyCode last_presed;

    // Movement Speed
    public float speed = 16;

    // Use this for initialization
    void Start() {
        //Trail
        puntos_trail = new List<Vector2>();
        // Initial Velocity
        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
        last_presed = upKey;
    }


    void OnTriggerEnter2D(Collider2D co)
    {
        print("Player lost:" + name);
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update () {
        float desiredAngle;
        // Check for key presses
        if (Input.GetKeyDown(upKey) && last_presed != downKey)
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
            desiredAngle = 0;
            transform.rotation = Quaternion.Euler(0, 0, desiredAngle);
            last_presed = upKey;
        }
        else if (Input.GetKeyDown(downKey) && last_presed != upKey)
        {
            GetComponent<Rigidbody2D>().velocity = -Vector2.up * speed;
            desiredAngle = 180;
            transform.rotation = Quaternion.Euler(0, 0, desiredAngle);
            last_presed = downKey;
        }
        else if (Input.GetKeyDown(rightKey) && last_presed != leftKey)
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
            desiredAngle = -90;
            transform.rotation = Quaternion.Euler(0, 0, desiredAngle);
            last_presed = rightKey;
        }
        else if (Input.GetKeyDown(leftKey) && last_presed != rightKey)
        {
            GetComponent<Rigidbody2D>().velocity = -Vector2.right * speed;
            desiredAngle = 90;
            transform.rotation = Quaternion.Euler(0, 0, desiredAngle);
            last_presed = leftKey;
        }
    }
    void FixedUpdate() {
        puntos_trail.Add(transform.position);
        col.GetComponent<EdgeCollider2D>().points = puntos_trail.ToArray();
    }

}
