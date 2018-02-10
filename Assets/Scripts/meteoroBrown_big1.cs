using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteoroBrown_big1 : MonoBehaviour {
    private float scrollingSpeed = 5f;

    void Start()
    {

    }

    void Update()
    {
        transform.Translate(Vector2.down * scrollingSpeed * Time.deltaTime);
        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
}
