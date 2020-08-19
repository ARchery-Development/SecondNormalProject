using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieSpawn : MonoBehaviour
{   
    public GameObject enemy1, enemy2, enemy3, enemy4;

	public float SpawnRate = 2f;
	float nextSpawn = 0.0f;
	int whatToSpawn;
	
    //public float kk = 4f;
	float randX,randZ;
	int i;
	Vector3 spawnPlace;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (Time.time > nextSpawn)
		{
			whatToSpawn = Random.Range(1, 4);
			nextSpawn = Time.time + SpawnRate;
			switch (whatToSpawn)
			{
		case 1:
            randX = Random.Range(-130, 130);
			randZ = Random.Range(-90, -80);
			spawnPlace = new Vector3(randX, 0.5226893f, randZ);
            Instantiate(enemy1, spawnPlace, Quaternion.identity);
			break;
		case 2:
            randX = Random.Range(-130, 130);
			randZ = Random.Range(80, 90);
			spawnPlace = new Vector3(randX, 0.5226893f, randZ);
            Instantiate(enemy2, spawnPlace, Quaternion.identity);
			break;
		case 3:
            randX = Random.Range(-100, 100);
			randZ = Random.Range(-90, -80);
			spawnPlace = new Vector3(randX, 0.5226893f, randZ);
            Instantiate(enemy3, spawnPlace, Quaternion.identity);
			break;
		case 4:
            randX = Random.Range(-100, 100);
			randZ = Random.Range(90, 80);
			spawnPlace = new Vector3(randX, 0.5226893f, randZ);
            Instantiate(enemy4, spawnPlace, Quaternion.identity);
			break;  
            }
        }
    }
}