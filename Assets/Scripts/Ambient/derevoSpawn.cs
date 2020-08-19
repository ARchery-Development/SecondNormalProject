using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class derevoSpawn : MonoBehaviour
{
  
	public GameObject derevo;
    public float kk = 4f;
	float randX,randZ;
	int i;
	Vector3 spawnPlace;
		void Start()
	{
		 for (i = 0; i < kk; i++)
		{
			randX = Random.Range(-100, 100);
			randZ = Random.Range(-100, -70);
			//Debug.Log("randX="+randX.ToString());
			spawnPlace = new Vector3(randX, 0.5226893f, randZ);
		    Instantiate(derevo, spawnPlace, Quaternion.identity);
		}
        for (i = 0; i < kk; i++)
		{
			randX = Random.Range(-100, 100);
			randZ = Random.Range(70, 100);
			//Debug.Log("randX="+randX.ToString());
			spawnPlace = new Vector3(randX, 0.5226893f, randZ);
		    Instantiate(derevo, spawnPlace, Quaternion.identity);

		}
        for (i = 0; i < kk; i++)
		{
			randX = Random.Range(-150, -120);
			randZ = Random.Range(-120, 120);
			//Debug.Log("randX="+randX.ToString());
			spawnPlace = new Vector3(randX, 0.5226893f, randZ);
		    Instantiate(derevo, spawnPlace, Quaternion.identity);
		}
        for (i = 0; i < kk; i++)
		{
			randX = Random.Range(120, 150);
			randZ = Random.Range(-120, 120);
			//Debug.Log("randX="+randX.ToString());
			spawnPlace = new Vector3(randX, 0.5226893f, randZ);
		    Instantiate(derevo, spawnPlace, Quaternion.identity);
		}
    }
	void Update()
	{
        
	}
}	
	


