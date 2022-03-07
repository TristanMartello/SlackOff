using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sus_mask : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    public float width;
    // Update is called once per frame
    void Update()
    {
        if (width < 800) {
            width = width + 1;
            GameObject mask = GameObject.Find ("Canvas/HUD/sus_mask");
            var mask_trans = mask.transform as RectTransform;
            mask_trans.sizeDelta = new Vector2 (width, mask_trans.sizeDelta.y);
        }
    }
}
