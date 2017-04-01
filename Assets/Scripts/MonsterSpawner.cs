using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MonsterSpawner : NetworkBehaviour
{

    public GameObject monster;
    private bool click = false;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1") && !click){
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                Instantiate(monster, hit.point, Quaternion.identity);
            }
        }
        else
        {
            click = false;
        }
    }
}
