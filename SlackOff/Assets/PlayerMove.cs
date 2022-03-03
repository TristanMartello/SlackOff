using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameInventory playerInventory;
    public Transform dropPoint;
    
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
        
        if (Input.GetKeyDown("space")) {
            //GameObject currItem = playerInventory.getCurrObj();
            playerInventory.InventoryRemove(playerInventory.getCurrName());
            
            //GameObject droppedItem = Instantiate(currItem, dropPoint.position, dropPoint.rotation);
            //gameObject.setActive(true);
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
