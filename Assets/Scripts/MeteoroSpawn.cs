// Universidad del Valle de Guatemala
// Programacion de plataformas moviles y juegos
// File: GameController.cs
// Spawn de meteoros
// Autores: Fernando Hengstenberg 17699 y David Valenzuela 171001

// Importamos clases necesarias
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoroSpawn : MonoBehaviour {
    //instancia de Meteoro1
    public GameObject meteor1;
    //tiempo de Spawn de los meteoros
    public float spawnTime = 0.5f;
    //lapso de tiempo para los meteoros
    public float elapsedTime = 0f;


    // Use this for initialization
    void Start()
    {      
        //variable random para generar el cualquier parte el meteoro
        float random = Random.Range(-6.68f, 7.18f);
        //Asignamos a GameObject
		meteor1.GetComponent<GameObject> ();
        //instanciamos para que se genere el meteoro 
        Instantiate(meteor1, new Vector3(random, 10, 0), Quaternion.identity);

    }
    // Update is called once per frame
    void Update()
    {   //
		if (GameController.instance.gameOver == false) {
			if (elapsedTime < spawnTime) {

                //elapsedTime 
				elapsedTime += Time.deltaTime;

			} else {
                //variable random
				float random = Random.Range (-6.68f, 7.18f);
                //instanciamos el meteoro 
				Instantiate (meteor1, new Vector3 (random, 20, 0), Quaternion.identity);
                //iniciamos variable elapsedTime sera igual a 0
				elapsedTime = 0;

			}
		}


    }
}
