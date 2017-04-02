using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotSpawnerScript : MonoBehaviour {
    public GameObject spawnie;
    public Camera cam;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Fired triggered");
            Instantiate(spawnie, transform.position, transform.rotation);
        }
    }
}