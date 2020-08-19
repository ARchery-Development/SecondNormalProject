using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class koostSpawn : MonoBehaviour
{
	public GameObject koost;
    public float kk = 4f;
	float randX,randZ;
	int i;
	Vector3 spawnPlace;

	void Start()
	{
		 for (i = 0; i < kk; i++)
		    {
			randZ = Random.Range(-100, 100);
			randX = Random.Range(-120, 120);
			spawnPlace = new Vector3(randX, 0.5226893f, randZ);
			Instantiate(koost, spawnPlace, Quaternion.identity);
			}   
		
	}

	void Update()
	{
        
	}
}	
	


