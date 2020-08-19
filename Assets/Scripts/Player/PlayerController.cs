using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //public GameObject ring, dot;
    Rigidbody rb;
    private Animator anim;
   // bool Jump, Sprint, Walk;
    private Touch oneTouch;
    private Vector3 touchPosition;
    //public float dx, dy, Clamp;
    public float moveSpeed = 12f;
    //public Transform target;
    private Camera cam;
    private int lastPB;
    private Vector2 mousePos, mousePosGUI, oneMouse, touchPosition2;

    void OnGUI()
    {
        Vector3 point = new Vector3();
        Event   currentEvent = Event.current;
         mousePosGUI.x = currentEvent.mousePosition.x;
         mousePosGUI.y = (cam.pixelHeight - currentEvent.mousePosition.y);
         mousePos=currentEvent.mousePosition;
         //x = mousePos.x;
         //y = mousePos.y;
         point = cam.ScreenToWorldPoint(new Vector3(mousePosGUI.x, mousePosGUI.y, cam.nearClipPlane));
        
        GUILayout.BeginArea(new Rect(20, 20, 250, 120));
        GUILayout.Label("Screen pixels: " + cam.pixelWidth + ":" + cam.pixelHeight);
        GUILayout.Label("Mouse position: " + mousePosGUI);
        GUILayout.Label("World position: " + point.ToString("F3"));
        GUILayout.EndArea();
    }

    void Start()
    {  
        anim = GetComponent<Animator>();
       /* anim.SetBool("Walk", false); 
        anim.SetBool("Jump", false);  
        anim.SetBool("Sprint", false);  */ 
       // transform.Rotate(0f, 0f, 0f);
        cam = Camera.main;
        
        rb = GetComponent<Rigidbody>();
       // Debug.Log("dot.transform.position = " + dot.transform.position);
       // Debug.Log("touchPosition2 = " + touchPosition2);
        
        //ring.transform.position.z = 0.0f;
        //ring.SetActive(false);
        //dot.SetActive(false);
    }

    void Update()

    {     
      
        if (Input.GetKey(KeyCode.W))
        {   
            /*anim.SetBool("Walk", false); 
            anim.SetBool("Jump", false);  */
            anim.SetBool("Sprint", true);          
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            transform.position += Vector3.forward * Time.deltaTime * moveSpeed;          
        }     
     
       if (Input.GetKey(KeyCode.S))
        {  
         /*  anim.SetBool("Walk", false); 
           anim.SetBool("Jump", false);  
           anim.SetBool("Sprint", true);   */
           transform.rotation = Quaternion.Euler(0f, 180f, 0f);
           transform.position += Vector3.back * Time.deltaTime * moveSpeed;            
        }    
        if (Input.GetKey(KeyCode.A))
        {   
           /* anim.SetBool("Walk", false); 
            anim.SetBool("Jump", false);  
            anim.SetBool("Sprint", true);   */           
            transform.rotation = Quaternion.Euler(0f, 270f, 0f);
            transform.position += Vector3.left * Time.deltaTime * moveSpeed;
        }
        else if (Input.GetKey(KeyCode.D))
        {
           /* anim.SetBool("Walk", false); 
            anim.SetBool("Jump", false);  
            anim.SetBool("Sprint", true);  */
            transform.rotation = Quaternion.Euler(0f, 90f, 0f);
            transform.position += Vector3.right * Time.deltaTime * moveSpeed;
        }
    }
   
   void FixedUpdate()
    {
     // if (Input.GetKey(KeyCode.W))
          
        /*    anim.SetBool("Walk", false); 
            anim.SetBool("Jump", false);  
            anim.SetBool("Sprint", true);*/
    }    
   /* private void PlayerMove()
    {
        
      //dot.transform.position = touchPosition;
      dot.transform.position = mousePosGUI; 
      //Debug.Log("PlayerMove touchPosition2 = "+touchPosition2); 
      dot.transform.position = new Vector2(
          Mathf.Clamp(dot.transform.position.x,
          ring.transform.position.x - Clamp,
          ring.transform.position.x + Clamp), 
          Mathf.Clamp(dot.transform.position.z,
          ring.transform.position.z - Clamp,
          ring.transform.position.z + Clamp));
          moveDirection = (dot.transform.position - ring.transform.position).normalized;
          rb.velocity = moveDirection * moveSpeed;
          Debug.Log("rb.velocity = " + rb.velocity); 
          Debug.Log("PlayerMove touchPosition2 = "+touchPosition2);
    }*/
}
