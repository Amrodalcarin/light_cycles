using UnityEngine;
using System.Collections.Generic;

public class TrailCollider : MonoBehaviour {
    private List<Vector2> puntos_trail;
    public GameObject col;

    // Use this for initialization
    void Start () {
        puntos_trail = new List<Vector2>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        puntos_trail.Add(transform.position);
        col.GetComponent<EdgeCollider2D>().points = puntos_trail.ToArray();
	}
}
