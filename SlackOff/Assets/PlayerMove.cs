using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed = 4f;
    public Vector2 movement;
    // Start is called before the first frame update
    void Start(){
        rb = GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void FixedUpdate(){
        movement.x = Input.GetAxisRaw ("Horizontal");
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        
        movement.y = Input.GetAxisRaw ("Vertical");
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
    
    void OnCollisionEnter2D(Collision2D other){
         if (other.gameObject.tag == "coin"){
              //gameObject.GetComponent<AudioSource>().Play();
              //GameObject boomFX = Instantiate(hitVFX, other.gameObject.transform.position, Quaternion.identity);
              //StartCoroutine(DestroyVFX(boomFX));

              Destroy(other.gameObject);
              Debug.Log("hit");
              //gameHandlerObj.AddScore(1);
         }
    }
}
