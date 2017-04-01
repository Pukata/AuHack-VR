using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotSpawnerScript : MonoBehaviour {
    public GameObject spawnie;
    public float spawnRate;
    private float nextSpawn;

    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;

            if (Input.GetButtonDown("Fire1"))
            {
                Instantiate(spawnie, transform.position, transform.rotation);
            }
        }
    }
}