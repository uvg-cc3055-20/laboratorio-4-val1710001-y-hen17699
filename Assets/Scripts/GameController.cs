// Universidad del Valle de Guatemala
// Programacion de plataformas moviles y juegos
// File: GameController.cs
// Controlador general del juego
// Autores: Fernando Hengstenberg 17699 y David Valenzuela 171001

// Importamos clases necesarias
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
	
	// Instancia de gamecontroller para modificar sus atributos
	public static GameController instance;
	// Puntaje del jugador
	public float score;
	// Jugador vivo o muerto
	public bool gameOver;
	// Texto puntaje mas alto
	public Text highScore;

	// Use this for initialization
	void Start () {
		// Iniciamos las variables
		instance = this;
		score = 0;
		gameOver = false;
		// Cargamos el puntaje mas alto
		highScore.text = "HigScore: " + PlayerPrefs.GetFloat ("HighScore",0).ToString ();
	}

}
	