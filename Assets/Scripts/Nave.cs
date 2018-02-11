// Universidad del Valle de Guatemala
// Programacion de plataformas moviles y juegos
// File: GameController.cs
// controlador de la Nave
// Autores: Fernando Hengstenberg 17699 y David Valenzuela 171001

// Importamos clases necesarias
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nave : MonoBehaviour {
    //creamos variable tipo RigidBody2D
    Rigidbody2D rb;
    //creamos variable de la velocidad tipo float
    private float speed = 8f;
    //creamos la variable de Score de tipo texto  
	public Text score;

	// Use this for initialization
	void Start () {
        //asignamos el componente Rigidbody2D
        rb = GetComponent<Rigidbody2D>();
		
	}
	
	// Update is called once per frame
	void Update () {
        //condicion para terminar la partida
		if (GameController.instance.gameOver == false) {
            //movimiento 
			float movX = Input.acceleration.x;
            //movimiento de la nave
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
