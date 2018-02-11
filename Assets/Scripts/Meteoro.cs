using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteoro : MonoBehaviour {

	private float scrollingSpeed = 5f;
	
	// Update is called once per frame
	void Update () {
		if (GameController.instance.gameOver == false) {
			transform.Translate (Vector2.down * scrollingSpeed * Time.deltaTime);
			if (transform.position.y < -6) {
				Destroy (gameObject);
			}
		}
	}
}
