using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameInventory playerInventory;
    public Transform dropPoint;
    public Animator animator;
    public bool isWalking = false;
    public bool isUp = false;
    public bool isDown = false;
    public GameObject currItem;
    
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
        animator.SetBool("isWalking", true);
        animator.SetBool("isDown", true);
        

        if (Input.GetKeyDown("space")) {
            playerInventory.InventoryRemove(playerInventory.getCurrName());
        }
        //Down
        if (Input.GetKeyDown("down")) {
            isWalking = true;
            isDown = true;
            animator.SetBool("isWalking", true);
            animator.SetBool("isDown", true);
        } else if (Input.GetKeyUp("down")) {
            isWalking = false;
            isDown = false;
            animator.SetBool("isWalking", false);
            animator.SetBool("isDown", false);
        }
        //
        if (Input.GetKeyDown("up")) {
            isWalking = true;
            isUp = true;
            animator.SetBool("isWalking", true);
            animator.SetBool("isUp", true);
        } else if (Input.GetKeyUp("up")) {
            isWalking = false;
            isUp = false;
            animator.SetBool("isWalking", false);
            animator.SetBool("isUp", false);
        }
        
        if (Input.GetKeyDown("left")) {
            animator.SetBool("isLeft", true);
        } else if (Input.GetKeyUp("left")) {
            animator.SetBool("isLeft", false);
        }
        
        if (Input.GetKeyDown("right")) {
            animator.SetBool("isRight", true);
        } else if (Input.GetKeyUp("right")) {
            animator.SetBool("isRight", false);
        }
    }
    
    void OnCollisionEnter2D(Collision2D other){
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "coin"){
            Destroy(other.gameObject);
            Debug.Log(heldItemName);
        
        } else if (other.gameObject.tag == "box") {
            Debug.Log("Box hit");
        }
    }
}
