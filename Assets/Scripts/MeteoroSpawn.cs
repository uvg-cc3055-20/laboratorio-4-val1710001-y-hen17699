﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoroSpawn : MonoBehaviour {
    public GameObject meteoroBrown_big1;
    public float spawnTime = 1.25f;
    public float elapsedTime = 0f;


    // Use this for initialization
    void Start()
    {
        float random = Random.Range(-2f, 2f);

        Instantiate(meteoroBrown_big1, new Vector3(8, random, 0), Quaternion.identity);

    }
    // Update is called once per frame
    void Update()
    {
        if (elapsedTime < spawnTime)
        {

            elapsedTime += Time.deltaTime;

        }


        else
        {

            float random = Random.Range(-2f, 2f);

            Instantiate(meteoroBrown_big1, new Vector3(8, random, 0), Quaternion.identity);
            elapsedTime = 0;

        }


    }
}
