using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieWalking : MonoBehaviour
{   
   // float smooth = 2.0f;
   // float tiltAngle = 30.0f;
    private Animator anim;
    public float speed = 12f;
    float i,d;
    Rigidbody rb;
    public GameObject target;
    Vector3 dir2Tar;

    void Start()
    {
      anim = GetComponent<Animator>();  
     //target = GameObject.Find("Player");
     rb = this.GetComponent<Rigidbody>();

    }       
    void Update()
    {         

    }

    void FixedUpdate()
    {
         MoveZombie();
      //  anim.SetBool("isStaying", false); 
         //  anim.SetBool("isRunning", true); 

    }

    void MoveZombie()
    {
        if (target != null)
        {
           dir2Tar = (target.transform.position-transform.position).normalized;
           rb.velocity = new Vector3(dir2Tar.x*speed, -1.931018f, dir2Tar.z*speed); 
          // anim.SetBool("isStaying", false); 
          // anim.SetBool("isRunning", true); 

          // Debug.Log("rb.velocity= "+rb.velocity);
        //   Debug.Log("rb.velocity= "+rb.velocity);
          // Debug.Log("rb.velocity= "+rb.velocity);
           // Debug.Log("rb.velocity= "+rb.velocity);
           //Debug.Log("MoveZombie target != null");
        }
        else 
        rb.velocity = Vector3.zero;
      //  anim.SetBool("isStaying", true); 
      //  anim.SetBool("isRunning", false); 
        //Debug.Log("MoveZombie else");
    }
    void OnCollisionEnter(Collision col)
    {
      if (col.gameObject.tag.Equals("Bullet"))
      {
        Debug.Log("Коснулся БУЛЛЕТА");
        Destroy(gameObject);
        Destroy(col.gameObject);
      }
    }
}
