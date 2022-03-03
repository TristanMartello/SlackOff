using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameInventory : MonoBehaviour {

    //5 Inventory Items:
    public GameObject InventoryMenu;

    public static bool diskBool = false;    
    public static string currItem = "None";
    public GameObject diskImage;
    
    public static int coins = 0;

    void Start(){
        InventoryMenu.SetActive(true);
        diskImage.SetActive(false);
    
        InventoryDisplay();
    }

    void InventoryDisplay(){
        if (diskBool == true) {
            diskImage.SetActive(true);
        } else {
            diskImage.SetActive(false);
        }
        
        //Text coinTextB = coinText.GetComponent ();
        //coinTextB.text = ("COINS: " + coins);
    }

    public void InventoryAdd(string item){
        string foundItemName = item;
        //Debug.Log("ITEM FOUND");
        if (foundItemName == "FloppyDisk") {
            diskBool = true;
        }
        currItem = foundItemName;
    
        InventoryDisplay();
    }
    
    public void InventoryRemove(string item){
        string itemRemove = item;
        if (itemRemove == "FloppyDisk") {
            diskBool = false;
        }
        currItem = "None";
        InventoryDisplay();
    }
    
    public GameObject getCurrObj(){
        if (currItem == "FloppyDisk") {
            return diskImage;
        } else {
            return null;
        }
    }

    public string getCurrName(){
        return currItem;
    }
    
    public void CoinChange(int amount){
        coins +=amount;
        InventoryDisplay();
    }
}