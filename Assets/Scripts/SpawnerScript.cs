using UnityEngine;
using System.Collections;

public class SpawnerScript : MonoBehaviour {

	public GameObject spawnie;
	public float spawnRate;
	private float nextSpawn;
    public bool shouldSpawn;
    public bool randomness;
    public int spawners;
    public bool isPlayer = false;

	void Update ()
	{
		if (shouldSpawn && Time.time > nextSpawn)
		{
            float num = Random.Range(0, spawners);
            nextSpawn = Time.time + spawnRate;

            if(randomness && num != 0 || !randomness)
                Instantiate(spawnie, transform.position, transform.rotation);
		}
	}		
} 
