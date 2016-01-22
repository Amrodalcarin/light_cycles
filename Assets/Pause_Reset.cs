using UnityEngine;
using System.Collections;

public class Pause_Reset : MonoBehaviour {

    public GameObject pause;
    // Use this for initialization
    void Start () {
        pause.active = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = (float)0;
                pause.active = true;
            }
            else
            {
                pause.active = false;
                Time.timeScale = 1;
            }
        };

        if (Input.GetKeyDown(KeyCode.R))
        {
            Application.LoadLevel("MainMenu");
        }
    }
}
