using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasInventory : MonoBehaviour
{
    public GameObject diskImage;
    public GameObject cubeImage;
    public GameObject bearImage;
    public GameObject paperImage;
    
    private GameObject[] objArr;
    
    public bool holdingItem = false;
    
    // Start is called before the first frame update
    void Start()
    {
        objArr = new GameObject[4];
        objArr[0] = diskImage;
        objArr[1] = cubeImage;
        objArr[2] = bearImage;
        objArr[3] = paperImage;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void pickUpItem(int i) {
        objArr[i].SetActive(true);
    }
    
    public void dropItem(int i) {
        objArr[i].SetActive(false);
    }
}
