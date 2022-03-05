using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameInventory : MonoBehaviour {

    //5 Inventory Items:
    public GameObject InventoryMenu;

    public static string currItem = "None";

    public static bool diskBool = false;
    public static bool cubeBool = false;
    //public static bool penBool = false;   
    public GameObject diskImage;
    public GameObject cubeImage;
    //public GameObject penImage;
    
    private int arrLen = 2;
    private GameObject[] objArr;
    private bool[] boolArr;
    
    void Start(){
        InventoryMenu.SetActive(true);
        diskImage.SetActive(false);
        cubeImage.SetActive(false);
        getArrays();
        
        InventoryDisplay();
    }

    void getArrays() {
        objArr = new GameObject[arrLen];
        boolArr = new bool[arrLen];
        
        objArr[0] = diskImage;
        objArr[1] = cubeImage;
        //objArr[2] =  penImage;

        boolArr[0] = diskBool;
        boolArr[1] = cubeBool;
        //boolArr[2] =  penBool;

    }

    void InventoryDisplay(){
        for (int i = 0; i < arrLen; i ++){
            if (boolArr[i]) {
                objArr[i].SetActive(true);
            } else {
                objArr[i].SetActive(false);
            }
        }
        //Text coinTextB = coinText.GetComponent ();
        //coinTextB.text = ("COINS: " + coins);
    }

    public void InventoryAdd(string item){
        string foundItemName = item;
        
        for (int i = 0; i < arrLen; i ++) {
            if (foundItemName == objArr[i].tag){
                boolArr[i] = true;
            }
        }
        
        currItem = foundItemName;
        InventoryDisplay();
    }
    
    public void InventoryRemove(string item){
        string itemRemove = item;
        
        for (int i = 0; i < arrLen; i ++){
            if (item == objArr[i].tag) {
                boolArr[i] = false;
            }
        }
        
        currItem = "None";
        InventoryDisplay();
    }
    
    public GameObject getCurrObj(){
        
        for (int i = 0; i < arrLen; i ++){
            if (currItem == objArr[i].tag) {
                return objArr[i];
            }
        }
        return null;
    
    }

    public string getCurrName(){
        return currItem;
    }
    
    public bool checkEmpty(){
        return (currItem == "None");
    }
    
    /*
    public void CoinChange(int amount){
        coins +=amount;
        InventoryDisplay();
    }
    */
}