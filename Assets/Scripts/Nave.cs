using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nave : MonoBehaviour {

    Rigidbody2D rb;
    private float speed = 8f;
	public Text score;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GameController.instance.gameOver == false) {
			float movX = Input.acceleration.x;
			rb.transform.Translate (Vector2.right * speed * movX * Time.deltaTime);
			GameController.instance.score = GameController.instance.score + 1 * Time.deltaTime;
			score.text = GameController.instance.score.ToString ();
		}
    }

	public void OnTriggerEnter2D(Collider2D collision){
		GameController.instance.gameOver = true;
		if (GameController.instance.score > PlayerPrefs.GetFloat ("HighScore", 0)) {
			PlayerPrefs.SetFloat ("HighScore", GameController.instance.score); 
		}
	}
}
