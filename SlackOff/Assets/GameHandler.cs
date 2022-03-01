using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHandler : MonoBehaviour
{
    public GameObject itemDisplayText;
    //private string itemName = "None";
    public GameObject player;
    //private int playerScore = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        SetItem();
    }

    /*
    // Update is called once per frame
    void Update()
    {
        
    }
    
    */
    void SetItem(){
        Text itemText = itemDisplayText.GetComponent<Text>();
        //string itemName = player.getHeldItem();
        //SitemText.text = " " + itemName;
    }
}
