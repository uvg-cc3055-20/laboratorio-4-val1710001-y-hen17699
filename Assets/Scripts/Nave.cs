using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nave : MonoBehaviour {

    Rigidbody2D rb;
    private float speed = 5f;


	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
		
	}
	
	// Update is called once per frame
	void Update () {
        float movX = Input.acceleration.x; rb.transform.Translate(Vector2.right * speed * movX * Time.deltaTime);

    }
}
