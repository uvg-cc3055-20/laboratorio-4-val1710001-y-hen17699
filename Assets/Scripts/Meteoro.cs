// Universidad del Valle de Guatemala
// Programacion de plataformas moviles y juegos
// File: GameController.cs
// Destuctor de meteoros 
// Autores: Fernando Hengstenberg 17699 y David Valenzuela 171001

// Importamos clases necesarias
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteoro : MonoBehaviour {

	private float scrollingSpeed = 5f;
	
	// Update is called once per frame
	void Update () {

        //condicion para Destruccion de meteoros
		if (GameController.instance.gameOver == false) {

       //movimiento de meteoros
			transform.Translate (Vector2.down * scrollingSpeed * Time.deltaTime);
			if (transform.position.y < -6) {
                //destruccion de meteoros
				Destroy (gameObject);
			}
		}
	}
}
