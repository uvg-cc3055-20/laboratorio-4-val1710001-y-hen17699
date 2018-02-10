using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour {
    public float ScrollingSpeed = 5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector2.down * ScrollingSpeed * Time.deltaTime);

        if (transform.position.y <= -8.08) 
        {
            transform.position = new Vector3(0.289f, transform.position.x, transform.position.z);

        }


    }
}
