using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class Move : MonoBehaviour {
    public GameObject canvas_gameover;
    public Text jugador;

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
        canvas_gameover.SetActive(false);
        // Initial Velocity
        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
        last_presed = upKey;
    }


    void OnTriggerEnter2D(Collider2D co)
    {
        Time.timeScale = 0;
        Destroy(gameObject);
        jugador.text = "Orange";
        canvas_gameover.SetActive(true);
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

}
