using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed = 4f;
    public Vector2 movement;
    public string heldItemName = "None";
    
    // Start is called before the first frame update
    void Start(){
        rb = GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void FixedUpdate(){
        movement.x = Input.GetAxisRaw ("Horizontal");
        movement.y = Input.GetAxisRaw ("Vertical");
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        
        
        //rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
    
    void OnCollisionEnter2D(Collision2D other){
        if (other.gameObject.tag == "coin"){
            //if (Input.GetKeyDown("space")){
            heldItemName = other.gameObject.tag;
            Destroy(other.gameObject);
            Debug.Log(heldItemName);
                //gameHandlerObj.AddScore(1);
            //}
        } else if (other.gameObject.tag == "box") {
            Debug.Log("Box hit");
        }
    }
}
