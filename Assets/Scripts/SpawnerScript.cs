using UnityEngine;
using System.Collections;

public class SpawnerScript : MonoBehaviour {

	public GameObject spawnie;
	public float spawnRate;
	private float nextSpawn;
    public bool shouldSpawn;
    public bool randomness;
    public int spawners;


	void Update ()
	{
		if (shouldSpawn && Time.time > nextSpawn)
		{
            float num = Random.Range(0, spawners);
            nextSpawn = Time.time + spawnRate;
            if (num == 0)
            {
                Instantiate(spawnie, transform.position, transform.rotation);
            }
           
		}
	}		
} 
