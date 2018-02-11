using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoroSpawn : MonoBehaviour {
    public GameObject meteor1;
    public float spawnTime = 0.5f;
    public float elapsedTime = 0f;


    // Use this for initialization
    void Start()
    {
        float random = Random.Range(-6.68f, 7.18f);
		meteor1.GetComponent<GameObject> ();
        Instantiate(meteor1, new Vector3(random, 10, 0), Quaternion.identity);

    }
    // Update is called once per frame
    void Update()
    {
		if (GameController.instance.gameOver == false) {
			if (elapsedTime < spawnTime) {

				elapsedTime += Time.deltaTime;

			} else {

				float random = Random.Range (-6.68f, 7.18f);

				Instantiate (meteor1, new Vector3 (random, 20, 0), Quaternion.identity);
				elapsedTime = 0;

			}
		}


    }
}
