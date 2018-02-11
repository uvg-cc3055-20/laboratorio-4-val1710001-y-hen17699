// Universidad del Valle de Guatemala
// Programacion de plataformas moviles y juegos
// File: GameController.cs
// Generador infinito del Fondo
// Autores: Fernando Hengstenberg 17699 y David Valenzuela 171001

// Importamos clases necesarias
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScrollingBackground : MonoBehaviour {
    //creamos la variable de la fuerza del fondo
    public float ScrollingSpeed = 5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //condicion para mover el fondo y repetirlo
		if (GameController.instance.gameOver == false) {
            //Hacer que el fondo viaje hacia abajo
			transform.Translate (Vector2.down * ScrollingSpeed * Time.deltaTime);
            //generar y repetir el fondo infinitamente
			if (transform.position.y <= -8.08) {
				transform.position = new Vector3 (0.289f, transform.position.x, transform.position.z);

			}

		} else {

            //al perder regresar a la escena menu para volver de nuevo 
			SceneManager.LoadScene ("Menu");
		}

    }
}
