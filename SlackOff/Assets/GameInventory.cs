using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameInventory : MonoBehaviour {

    //5 Inventory Items:
    public GameObject InventoryMenu;

    public static bool item1bool = false;    
    public GameObject item1image;
    
    public static int coins = 0;

    void Start(){
        InventoryMenu.SetActive(true);
        item1image.SetActive(false);
    
        InventoryDisplay();
    }

    void InventoryDisplay(){
        if (item1bool == true) {
            item1image.SetActive(true);
        } else {
            item1image.SetActive(false);
        }
        
        //Text coinTextB = coinText.GetComponent ();
        //coinTextB.text = ("COINS: " + coins);
    }

    public void InventoryAdd(string item){
        string foundItemName = item;
        //Debug.Log("ITEM FOUND");
        if (foundItemName == "item1") {item1bool = true;}
    
        InventoryDisplay();
    }

    public void InventoryRemove(string item){
        string itemRemove = item;
        if (itemRemove == "item1") {item1bool =false;}
    
        InventoryDisplay();
    }

    public void CoinChange(int amount){
        coins +=amount;
        InventoryDisplay();
    }
}