using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Pause_Reset : MonoBehaviour {
    public GameObject canvas;
    // Use this for initialization
    void Start () {
        canvas.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = (float)0;
                canvas.SetActive(true);
            }
            else
            {
                canvas.SetActive(false);
                Time.timeScale = 1;
            }
        };
    }

    public void Reset()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
