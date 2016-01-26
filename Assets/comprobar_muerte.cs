using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class comprobar_muerte : MonoBehaviour {
    public GameObject canvas;
    public Text jugador;
	// Use this for initialization
	void Start () {
        canvas.SetActive(false);
	}

    void OnTriggerEnter2D(Collider2D co)
    {
        Time.timeScale = 0;       
        if (name == "Player_green")
        {
            jugador.text = "Orange";
        }
        else
        {
            jugador.text = "Green";
        }
        Destroy(gameObject);
        canvas.SetActive(true);
    }
}
