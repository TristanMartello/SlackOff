using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class ItemContainer: MonoBehaviour {

    public GameInventory playerInventory;
    public string ItemName;

    void Awake(){
        if (GameObject.FindWithTag("GameHandler") != null) {
           playerInventory = GameObject.FindWithTag("GameHandler").GetComponent<GameInventory>();
        }
    }

    void OnTriggerEnter2D(Collider2D other){
        Debug.Log("On trigger collision");
        if (other.gameObject.tag == "Player"){
            Debug.Log("You found a " + ItemName);
            playerInventory.InventoryAdd(ItemName);
            //playerInventory.removeObjectFromLevel(ItemName);
            Destroy(gameObject);
            //gameObject.setActive(false);
        }
    }
}