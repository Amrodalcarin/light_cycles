using UnityEngine;
using System.Collections;

public class comprobar_muerte : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    void OnTriggerEnter2D(Collider2D co)
    {
        print("Player lost:" + name);
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update () {
	
	}
}
