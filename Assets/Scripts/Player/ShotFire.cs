using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotFire : MonoBehaviour
{
    
    public Rigidbody bullet;
    private GameObject barrelObj;
    private Transform barrel;
    public int bulletSpeed = 50;
    private float nextFire = 0f;
    private float fireRate = 0.5f;

    void Start()
    {
        //bulletRb = bi
        barrelObj = GameObject.Find("/Player/Revolver/Barrel");
        barrel = barrelObj.transform;
        
    }
    void FixedUpdate()
    {
        //if (Input.GetButtonDown("Space"))
        if (Input.GetKey("space") && Time.time > nextFire)
        {
            Debug.Log("Нажат пробел");
            nextFire = Time.time + fireRate;
           var spawnedBullet = Instantiate(bullet, barrel.position, barrel.rotation);
           //spawnedBullet.gameObject.transform = new Vector3(5f, 5f, 5f);
           Destroy(spawnedBullet.gameObject, 4);
           Debug.Log("spawnedBullet.gameObject.transform = " + spawnedBullet.gameObject.transform);
           //spawnedBullet.AddForce(transform.forward * bulletSpeed);
          // spawnedBullet.transform 
          spawnedBullet.velocity = transform.forward * bulletSpeed;
        } 
    }
  
}