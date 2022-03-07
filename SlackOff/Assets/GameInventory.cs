using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameInventory : MonoBehaviour {

    //5 Inventory Items:

    public static string currItem = "None";
    public GameObject inventoryText;
    
    void Start(){
    }

    public void InventoryAdd(string item){
        string foundItemName = item;
        currItem = foundItemName;
        
        Text invText = inventoryText.GetComponent<Text>();
        invText.text = ("Holding: " + currItem);
        
    }
    
    public void InventoryRemove(){
        Text invText = inventoryText.GetComponent<Text>();
        invText.text = ("Holding: Nothing");
        
        currItem = "None";
    }

    public string getCurrName(){
        return currItem;
    }
    
    public bool checkEmpty(){
        return (currItem == "None");
    }
    
}