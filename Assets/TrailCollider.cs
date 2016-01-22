using UnityEngine;
using System.Collections.Generic;

public class TrailCollider : MonoBehaviour {
    private List<Vector2> puntos_trail;
    private List<Vector2> buffer_puntos;
    int contador_puntos;
    public GameObject col;

    // Use this for initialization
    void Start () {
        contador_puntos = 3;
        puntos_trail = new List<Vector2>();
        buffer_puntos = new List<Vector2>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        //if (contador_puntos > 0)
        //{
        //    buffer_puntos.Add(transform.position);
        //    contador_puntos--;
        //}
        //else
        //{
        //    buffer_puntos.Add(transform.position);
        //    Vector2 aux;
        //    aux = buffer_puntos[0];
        //    buffer_puntos.RemoveAt(0);
        //    puntos_trail.Add(aux);
        //    col.GetComponent<EdgeCollider2D>().points = puntos_trail.ToArray();
        //}
    }
}
