using UnityEngine;
using System.Collections;

public class SpawnerScript : MonoBehaviour {

	public GameObject spawnie;
	public float spawnRate;
	private float nextSpawn;
    public bool shouldSpawn;
    public bool randomness;
    public int spawners;
    public float power = 2.0f;

	void Update ()
	{
		if (shouldSpawn && Time.time > nextSpawn && Input.GetButtonDown("Fire1"))
		{
            float num = Random.Range(0, spawners);
            nextSpawn = Time.time + spawnRate;

            if (num == 0)
            {
                GameObject bullet = (GameObject) Instantiate(spawnie, transform.position, Camera.main.transform.rotation);

                bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * power;

                // destroy bullet after 2 seconds
                Destroy(bullet, 2.0f);

            }
           
		}
	}		
} 
